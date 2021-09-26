using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using SDRSharp.Common;

namespace SDRSharp.Plugin.SatControl
{
    public partial class SatControlPanel : UserControl
    {
        private RigControlProcess _radio;
        private SatControlProcess _satellite;
        private ISharpControl _control;
        private RotControlProcess _rotor;
        private bool ShowTransmitter = false;
        private bool TransmitterReset = false;
        private bool SatelliteFrequencyReset = false;

        // Satellite Control Free RX Tune
        private long prevSdrRxFreq = 0; 
        private long startRxFreq = 0; 
        private long rxDoppler = 0;
        private long txDoppler = 0;
        private long startTxFreq = 0;


        public SatControlPanel(RigControlProcess radio, SatControlProcess satellite, ISharpControl control, RotControlProcess rottor)
        {
            InitializeComponent();

            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            lblVersion.Text = "v" + fvi.FileMajorPart + "." + fvi.FileMinorPart + " dev by E29AHU";

            _radio = radio;
            _radio.rigStatus += _process_rigStatus;

            _satellite = satellite;
            _satellite.satRefresh += _satellite_satRefresh;

            _control = control;

            _rotor = rottor;
            _rotor.rotorUpdate += _rotor_rotorUpdate;

            // Prepare list Radio;
            cbRig.Items.Add("Rig1");
            cbRig.Items.Add("Rig2");
            cbRig.SelectedIndex = 0;

            resetGui();
       
            // load satellite list
            ArrayList satnames = _satellite.getSatelliteList();
            foreach(string satname in satnames)
            {
                cbSateList.Items.Add(satname);
            }
            cbSateList.SelectedIndex = 0;

            // get TxOffset from config
            nudTxOffset.Text = _radio.getTxOffsetFromConfig();
        }


        private void resetGui()
        {
            lblRigName.Text = "";
            lblStatus.Text = "";
            lblFrequency.Text = "";
            lblMode.Text = "";
            lblSpeed.Text = "";
            lblAos.Text = "";
            lblMaxEl.Text = "";

            lblAzimuth.Text = "";
            lblElevation.Text = "";
            lblDistance.Text = "";
            lblRx.Text = "";
            lblTx.Text = "";
            lblSatMode.Text = "";
            lblDoppler.Text = "";
            lblRxDoppler.Text = "";
            lblTxDoppler.Text = "";

            lblRotorAz.Text = "";
            lblRotorEl.Text = "";
        }


        // ##################################################################################
        // Satellite Control
        private void _satellite_satRefresh()
        {
            double Az = _satellite.observation.Azimuth.Degrees;
            double El = _satellite.observation.Elevation.Degrees;
            double range = _satellite.observation.Range;
            double rangeRate = _satellite.observation.RangeRate;

            lblAzimuth.Text = Az.ToString("#0.##0°");
            lblElevation.Text = El.ToString("#0.##0°"); ;
            lblDistance.Text = range.ToString("#0.##0 km");
            lblSpeed.Text = rangeRate.ToString("#0.##0 km/s");
            lblAos.Text = _satellite.satInfo.deltaTime.ToString(@"hh\:mm\:ss");
            lblMaxEl.Text = _satellite.satInfo.MaxEl.ToString("0.0°");

            if (ShowTransmitter == true)
            {

                int i = cbTransmitter.SelectedIndex;
                long rxFreqHigh = Convert.ToInt64(_satellite.transmitterSelected.ElementAt(i).Value.downlink_high);
                long rxFreqLow = Convert.ToInt64(_satellite.transmitterSelected.ElementAt(i).Value.downlink_low);
                long txFreqHigh = Convert.ToInt64(_satellite.transmitterSelected.ElementAt(i).Value.uplink_high);
                long txFreqLow = Convert.ToInt64(_satellite.transmitterSelected.ElementAt(i).Value.uplink_low);
                string upMode = Convert.ToString(_satellite.transmitterSelected.ElementAt(i).Value.uplink_mode);
                string dnMode = Convert.ToString(_satellite.transmitterSelected.ElementAt(i).Value.mode);
                bool invert = _satellite.transmitterSelected.ElementAt(i).Value.invert;

                long rxFreq = 0;
                long txFreq = 0;


                lblRx.Text = "";
                if (rxFreqHigh != 0)
                {
                    lblRx.Text = rxFreqLow / 1000 + " - " + rxFreqHigh / 1000 + " kHz";
                    rxFreq = rxFreqHigh - ((rxFreqHigh - rxFreqLow) / 2);
                }
                else
                {
                    lblRx.Text = rxFreqLow / 1000 + " kHz";
                    rxFreq = rxFreqLow;
                }

                lblTx.Text = "";
                if (txFreqHigh != 0)
                {
                    lblTx.Text = txFreqLow / 1000 + " - " + txFreqHigh + " kHz";
                    txFreq = txFreqHigh - ((txFreqHigh - txFreqLow) / 2);
                }
                else if (txFreqLow != 0)
                {
                    lblTx.Text = txFreqLow / 1000 + " kHz";
                    txFreq = txFreqLow;
                }
                else
                {
                    lblTx.Text = "n/a";
                }

                lblSatMode.Text = "";
                if (upMode != null)
                {
                    lblSatMode.Text = "Up:" + upMode + " / Dn:" + dnMode;
                }
                else
                {
                    lblSatMode.Text = dnMode;
                }

                if (TransmitterReset == true || SatelliteFrequencyReset == true) // Set SDR and Radio frequency to Satellite RX frequency
                {
                    startTxFreq = txFreq;
                    startRxFreq = rxFreq;
                    prevSdrRxFreq = rxFreq;
                    _control.Frequency = rxFreq;
                    _control.CenterFrequency = rxFreq;

                    switch (dnMode)
                    {
                        case "LSB":
                            _control.DetectorType = Radio.DetectorType.LSB; break;
                        case "USB":
                            _control.DetectorType = Radio.DetectorType.USB; break;
                        case "CW":
                            _control.DetectorType = Radio.DetectorType.CW; break;
                        case "FM":
                            _control.DetectorType = Radio.DetectorType.NFM; break;
                        default:
                            _control.DetectorType = Radio.DetectorType.NFM; break;
                    }

                }

                if (_control.Frequency != prevSdrRxFreq) // Free Tune Option
                {
                    startRxFreq = _control.Frequency - rxDoppler;
                }

                // RX Doppler
                lblDoppler.Text = "";
                rxDoppler = (long)_satellite.observation.GetDopplerShift((double)startRxFreq);
                lblDoppler.Text = rxDoppler + " Hz";
                _control.Frequency = startRxFreq + rxDoppler;
                lblRxDoppler.Text = ((double)_control.Frequency / 1000).ToString("#0.#0 kHz");
                prevSdrRxFreq = _control.Frequency;


                // TX Doppler
                if (txFreq != 0)
                {
                    txDoppler = -(long)_satellite.observation.GetDopplerShift((double)startTxFreq);
                    lblDoppler.Text += " / " + txDoppler + " Hz";
                    long rigTxFreq = startTxFreq + txDoppler;
                    if (invert == true)
                    {
                        rigTxFreq += (rxFreq - startRxFreq);
                    }
                    lblTxDoppler.Text = ((double)rigTxFreq / 1000).ToString("#0.#0 kHz");

                    // send to radio control
                    if (chkRigEnable.Checked)
                    {
                        _radio.satInfo.frequency = rigTxFreq + Convert.ToInt64(nudTxOffset.Value);
                        //_radio.rigInfo.mode = upMode;
                    }
                }
                else
                {
                    lblTxDoppler.Text = "n/a";
                }


                // Update RotorData
                if (chkRotorEnable.Checked)
                {
                    if(Az>0 && El>0) // If Satellite Available. send command to rotor
                    //if(true)
                    {
                        _rotor.setPosition(Az, El);
                        //_rotor.setPosition(90, 0);
                    }
                }


                TransmitterReset = false;
                SatelliteFrequencyReset = false;
            }

        }


        private void cbSateList_SelectedIndexChanged(object sender, EventArgs e)
        {
            _satellite.connectSatellite(cbSateList.SelectedIndex);

            // Update Satellite Mode
            cbTransmitter.Items.Clear();
            foreach (string txDetail in _satellite.transmitterSelectedDisplay)
            {
                cbTransmitter.Items.Add(txDetail);
            }

            cbTransmitter.SelectedIndex = 0;
                
        }

        private void cbTransmitter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowTransmitter = true;
            TransmitterReset = true;
        }

        private void chkSatEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSatEnable.Checked)
            {
                _satellite.serviceStart();
            }
            else
            {
                _satellite.serviceStop();
                resetGui();
            }
        }




        // ###########################################################################
        // Radio Control
        private void bb_omniRigConfig_Click(object sender, EventArgs e)
        {
            _radio.OmniRigConfig();

        }

        private void _process_rigStatus()
        {
            lblStatus.Text = _radio.rigInfo.status;
            lblFrequency.Text = ((_radio.rigInfo.frequency - nudTxOffset.Value)/1000).ToString("#0.#0 kHz");
            lblMode.Text = _radio.rigInfo.mode;
            lblRigName.Text = _radio.rigInfo.rigName;
        }

        private void chkRigEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRigEnable.Checked)
            {
                _radio.connectRig(cbRig.Text);
            }
            else
            {
                _radio.disConnectRig();
                lblStatus.Text = "";
                lblFrequency.Text = "";
                lblMode.Text = "";
                lblRigName.Text = "";
            }
        }

        private void bb_satReset_Click(object sender, EventArgs e)
        {
            SatelliteFrequencyReset = true;
        }

        private void bb_rigFM_Click(object sender, EventArgs e)
        {
            _radio.setModeFM();
        }

        private void bb_rigLSB_Click(object sender, EventArgs e)
        {
            _radio.setModeLSB();
        }

        private void bb_rigUSB_Click(object sender, EventArgs e)
        {
            _radio.setModeUSB();
        }

        private void bb_rigCW_Click(object sender, EventArgs e)
        {
            _radio.setModeCW();
        }


        // ###########################################################################
        // Rotor Control
        private void chkRotorEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRotorEnable.Checked)
            {
                lblRotMsg.Text = _rotor.connect();
            }
            else
            {
                lblRotMsg.Text = "";
                _rotor.disconnect();
            }
        }

        private void _rotor_rotorUpdate()
        {
            lblRotorAz.Text = Convert.ToString(_rotor.rotInfo.Az);
            lblRotorEl.Text = Convert.ToString(_rotor.rotInfo.El);
        }

        private void bbRotorUp_MouseDown(object sender, MouseEventArgs e)
        {
            _rotor.rotateUp();
        }
        private void bbRotorDn_MouseDown(object sender, MouseEventArgs e)
        {
            _rotor.rotateDn();
        }

        private void bbRotorLeft_MouseDown(object sender, MouseEventArgs e)
        {
            _rotor.rotateLeft();
        }

        private void bbRotorRight_MouseDown(object sender, MouseEventArgs e)
        {
            _rotor.rotateRight();
        }

        private void bbRotorDn_MouseUp(object sender, MouseEventArgs e)
        {
            _rotor.rotateStop();
        }

        private void bbRotorUp_MouseUp(object sender, MouseEventArgs e)
        {
            _rotor.rotateStop();
        }

        private void bbRotorLeft_MouseUp(object sender, MouseEventArgs e)
        {
            _rotor.rotateStop();
        }

        private void bbRotorRight_MouseUp(object sender, MouseEventArgs e)
        {
            _rotor.rotateStop();
        }

    }
}
