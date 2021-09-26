using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGPdotNET.TLE;
using SGPdotNET.Observation;
using SGPdotNET.CoordinateSystem;
using System.Collections;
using System.Timers;
using SGPdotNET.Util;
using System.Net;
using System.IO;
using System.Text.Json;
using System.Configuration;

namespace SDRSharp.Plugin.SatControl
{
    public class SatControlProcess
    {
        private Dictionary<int, Tle> tles;
        
        private Satellite sat;
        private GroundStation gs;
        public TopocentricObservation observation;

        public event Action satRefresh;
        Timer timer;

        AppSettingsSection config = ConfigurationManager.OpenExeConfiguration(System.Reflection.Assembly.GetExecutingAssembly().Location).AppSettings;


        public Dictionary<int, TransmitterDetail> transmitterSelected;
        public ArrayList transmitterSelectedDisplay;
        public SatInfo satInfo;
        public class TransmitterDetail
        {
            //public string uuid;
            public string description { get; set; }
            //public bool alive;
            //public string type { get; set; }
            public Nullable<double> uplink_low { get; set; }
            public Nullable<double> uplink_high { get; set; }
            //public long uplink_drift;
            public Nullable<double> downlink_low { get; set; }
            public Nullable<double> downlink_high { get; set; }
            //public long downlink_drift;
            public string mode { get; set; }
            public Nullable<double> mode_id { get; set; }
            public string uplink_mode { get; set; }
            public bool invert { get; set; }
            public Nullable<double> baud { get; set; }
            //public string sat_id;
            public Nullable<uint> norad_cat_id { get; set; }
            //public string status;
            //public string updated;
            //public string citation;
            //public string service;
            //public string coordination;
            //public string coordination_url;
        }

        public class SatInfo
        {
            public TimeSpan deltaTime { get; set; }
            public DateTime aos { get; set; }
            public double MaxEl { get; set; }

        }

        public SatControlProcess()
        {

            // download Transmitter Data
            try
            {     
                WebClient Client = new WebClient();
                //Client.DownloadFile("https://db.satnogs.org/api/tle/?format=json", @"tle.json");
                Client.DownloadFile("https://db.satnogs.org/api/transmitters/?format=json", @"transmitters.json");
            }
            catch(Exception ex)
            {

            }

            // Remote URL
            var url = new Uri("https://celestrak.com/NORAD/elements/amateur.txt");

            // Create a provider whose cache is renewed every 12 hours
            var provider = new CachingRemoteTleProvider(true, TimeSpan.FromHours(12), "tle.txt", url);
            //var provider = new RemoteTleProvider(true, url);

            // Get every TLE
            tles = provider.GetTles();

            timer = new Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;

            satInfo = new SatInfo();


            // Set up our ground station location
            var lat = Convert.ToDouble(config.Settings["QTH_Latitude"].Value);
            var lon = Convert.ToDouble(config.Settings["QTH_Lontitude"].Value);
            var location = new GeodeticCoordinate(Angle.FromDegrees(lat), Angle.FromDegrees(lon), 0.11);
            gs = new GroundStation(location);

            transmitterSelected = new Dictionary<int, TransmitterDetail>();
            transmitterSelectedDisplay = new ArrayList();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            // Observe the satellite
            DateTime startTime = new DateTime(
                DateTime.UtcNow.Year
                , DateTime.UtcNow.Month
                , DateTime.UtcNow.Day
                , DateTime.UtcNow.Hour
                , DateTime.UtcNow.Minute
                , DateTime.UtcNow.Second
                , DateTimeKind.Utc
                );

            DateTime endTime = new DateTime(
                DateTime.UtcNow.Year
                , DateTime.UtcNow.Month
                , DateTime.UtcNow.Day
                , DateTime.UtcNow.Hour
                , DateTime.UtcNow.Minute
                , DateTime.UtcNow.Second
                , DateTimeKind.Utc
                ).AddDays(1);

            TimeSpan tp = endTime - startTime;

            observation = gs.Observe(sat, startTime);
            List<SatelliteVisibilityPeriod> sv = gs.Observe(sat, startTime, endTime, TimeSpan.FromSeconds(10));
            if (sv.Count > 0)
            {
                if (sv[0].Start > startTime)
                {
                    satInfo.deltaTime = sv[0].Start - startTime;
                }
                else
                {
                    satInfo.deltaTime = sv[0].End - startTime;
                }
                satInfo.MaxEl = sv[0].MaxElevation.Degrees;
            }

            satRefresh?.Invoke();
        }

        // list all satellite
        public ArrayList getSatelliteList()
        {
            ArrayList satnames = new ArrayList();
            foreach (KeyValuePair<int, Tle> tle in tles)
            {
                satnames.Add(tle.Value.Name);
            }

            return satnames;
        }

        public void connectSatellite(int satIndex)
        {
            // Create a satellite from the TLEs
            Tle tle = tles.ElementAt(satIndex).Value;
            sat = new Satellite(tle);
            readTransmitterData(sat.Tle.NoradNumber);
        }

        private void readTransmitterData(uint satid)
        {
            string fileName = "transmitters.json";
            string jsonString = File.ReadAllText(fileName);
            TransmitterDetail[] txDetails = JsonSerializer.Deserialize<TransmitterDetail[]>(jsonString);

            transmitterSelected.Clear();
            transmitterSelectedDisplay.Clear();
            int index = 0;
            foreach (TransmitterDetail txDetail in txDetails)
            {
                if(txDetail.norad_cat_id==satid)
                {
                    transmitterSelected.Add(index, txDetail);
                    transmitterSelectedDisplay.Add(txDetail.description);
                }
                index++;
            }
        }


        public void serviceStart()
        {
            if (timer.Enabled != true)
            {
                timer.Start();
            }
        }

        public void serviceStop()
        {
            if (timer.Enabled == true)
            {
                timer.Stop();
            }
        }
    }
}
