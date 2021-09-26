using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Configuration;
using System.Timers;

namespace SDRSharp.Plugin.SatControl
{
    public class RotControlProcess
    {

        static SerialPort _serialPort;
        AppSettingsSection config = ConfigurationManager.OpenExeConfiguration(System.Reflection.Assembly.GetExecutingAssembly().Location).AppSettings;

        Timer timer;
        public RotInfo rotInfo;
        public event Action rotorUpdate;

        public class RotInfo
        {
            public double Az { get; set; }
            public double El { get; set; }
        }
        public RotControlProcess()
        {
            _serialPort = new SerialPort();
            _serialPort.PortName = config.Settings["PortName"].Value;
            _serialPort.BaudRate = Convert.ToInt32(config.Settings["BaudRate"].Value);
            _serialPort.DataBits = 8;
            _serialPort.Parity = Parity.None;
            _serialPort.StopBits = StopBits.One;
            //_serialPort.Handshake = Handshake.None;
            _serialPort.DataReceived += _serialPort_DataReceived;

            timer = new Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;

            rotInfo = new RotInfo();
        }

        private void _serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = _serialPort.ReadLine().Replace("\r", "");
            if (data.Length == 10)
            {
                rotInfo.Az = Convert.ToDouble(data.Substring(1, 4));
                rotInfo.El = Convert.ToDouble(data.Substring(6, 4));
            }

            rotorUpdate?.Invoke();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                _serialPort.Write("C2\r\n"); // Read Az El
            }
            catch { }
        }

        public string connect()
        {
            string ret = "";
            try
            {
                _serialPort.Open();
                timer.Start();
            }
            catch(Exception ex)
            {
                ret = ex.Message;
            }
            return ret;
        }

        public void disconnect()
        {
            rotateStop();
            try
            {
                _serialPort.Close();
                timer.Stop();
            }
            catch { }
        }

        public void setPosition(double setAz, double setEl)
        {
            double threshold = Convert.ToDouble(config.Settings["RotorTolerenceThreshold"].Value);
            if(Math.Abs(setAz - rotInfo.Az) > threshold || Math.Abs(setEl-rotInfo.El) > threshold )
            try
            {
                rotateLowSpeed();
                string cmd = "W" + setAz.ToString("000") + " " + setEl.ToString("000") + "\r\n";
                _serialPort.Write(cmd); // Read Az El
                rotateHighSpeed();
            }
            catch { }
        }

        public void rotateLowSpeed()
        {
            try
            {
                string cmd = "X1\r\n";
                _serialPort.Write(cmd); // Read Az El
            }
            catch { }
        }

        public void rotateHighSpeed()
        {
            try
            {
                string cmd = "X4\r\n";
                _serialPort.Write(cmd); // Read Az El
            }
            catch { }
        }
        public void rotateUp()
        {
            try
            {
                string cmd = "U\r\n";
                _serialPort.Write(cmd); // Read Az El
            }
            catch { }
        }

        public void rotateDn()
        {
            try
            {
                string cmd = "D\r\n";
                _serialPort.Write(cmd); // Read Az El
            }
            catch { }
        }

        public void rotateLeft()
        {
            try
            {
                string cmd = "L\r\n";
                _serialPort.Write(cmd); // Read Az El
            }
            catch { }
        }

        public void rotateRight()
        {
            try
            {
                string cmd = "R\r\n";
                _serialPort.Write(cmd); // Read Az El
            }
            catch { }
        }

        public void rotateStop()
        {
            try
            {
                string cmd = "S\r\n";
                _serialPort.Write(cmd); // Read Az El
            }
            catch { }
        }

    }
}
