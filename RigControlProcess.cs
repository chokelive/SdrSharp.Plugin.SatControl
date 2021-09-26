using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OmniRig;
using System.Timers;
using SDRSharp.Common;
using System.Xml;
using System.IO;
using System.Configuration;

namespace SDRSharp.Plugin.SatControl
{
    public class RigInfo
    {
        public long frequency { get; set; }
        public string mode { get; set; }
        public string  status { get; set; }
        public string rigName { get; set; }
        public string ctts { get; set; }
    }

    public class SatInfo
    {
        public long frequency { get; set; }
        public string mode { get; set; } = "";
    }


    public class RigControlProcess
    {
        private OmniRigX omniRig;
        private IRigX rig = null;
        ISharpControl _control;
        private Timer timer;
        public RigInfo rigInfo;
        public SatInfo satInfo;

        public event Action rigStatus;

        // App setting;
        AppSettingsSection config = ConfigurationManager.OpenExeConfiguration(System.Reflection.Assembly.GetExecutingAssembly().Location).AppSettings;
        public RigControlProcess(ISharpControl control)
        {
            _control = control;

            omniRig = new OmniRigX();
            rig = omniRig.Rig1;

            timer = new Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;

            rigInfo = new RigInfo();
            satInfo = new SatInfo();
        }

        public void OmniRigConfig()
        {
            omniRig.DialogVisible = true;
        }

        public void connectRig(string rigSelect)
        {
            if (rigSelect == "Rig1")
            {
                rig = omniRig.Rig1;
            }
            else if(rigSelect == "Rig2")
            {
                rig = omniRig.Rig2;
            }

            timer.Start();

        }

        public void disConnectRig()
        {
            timer.Stop();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            // Set Rig Frequency
            rig.FreqA = Convert.ToInt32(satInfo.frequency);

            // read Rig Info
            rigInfo.status = rig.StatusStr;
            rigInfo.frequency = rig.FreqA;
            
            switch (rig.Mode)
            {
                case RigParamX.PM_AM:
                    rigInfo.mode = "AM"; break;
                case RigParamX.PM_CW_L:
                    rigInfo.mode = "CW-L"; break;
                case RigParamX.PM_CW_U:
                    rigInfo.mode = "CW-U"; break;
                case RigParamX.PM_SSB_L:
                    rigInfo.mode = "LSB"; break;
                case RigParamX.PM_SSB_U:
                    rigInfo.mode = "USB"; break;
                case RigParamX.PM_FM:
                    rigInfo.mode = "FM"; break;
            }
            rigInfo.rigName = rig.RigType;

            rigStatus?.Invoke();
        }

        public string getTxOffsetFromConfig()
        {           
            string txOffset = config.Settings["TxOffset"].Value;
            return txOffset;
        }


        
        public void setModeFM()
        {
            rig.Mode = RigParamX.PM_FM;
        }

        public void setModeLSB()
        {
            rig.Mode = RigParamX.PM_SSB_L;
        }

        public void setModeUSB()
        {
            rig.Mode = RigParamX.PM_SSB_U;
        }

        public void setModeCW()
        {
            rig.Mode = RigParamX.PM_CW_L;
        }

    }

}
