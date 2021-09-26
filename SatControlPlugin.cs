using SDRSharp.Common;
//using SDRSharp.Plugin.RigControl;
//using SDRSharp.Radio;
using System;
using System.Windows.Forms;

namespace SDRSharp.Plugin.SatControl
{

    public class SatControlPlugin : ISharpPlugin, ICanLazyLoadGui
    {
        private const string _displayName = "Satellite Control";
        private ISharpControl _control;

        private SatControlPanel _configGui;
        private RigControlProcess _radio;
        private SatControlProcess _satellite;
        private RotControlProcess _rotor;
         
        public string DisplayName
        {
            get { return _displayName; }
        }

        public UserControl Gui
        {
            get
            {
                LoadGui();
                return _configGui;
            }
        }

   
        public void Initialize(ISharpControl control)
        {
            _control = control;
            _radio = new RigControlProcess(_control); // load Rig Control Plugin
            _satellite = new SatControlProcess(); // load Satelite Control Plugin
            _rotor = new RotControlProcess(); // load Rotor Control Plugin
        }


        public void Close()
        {
            _control = null;
            _radio = null;
            _satellite = null;
        }

        public void LoadGui()
        {
            if (_configGui == null)
            {
                _configGui = new SatControlPanel(_radio, _satellite, _control, _rotor);
            }
        }
    }
    
}
