
namespace SDRSharp.Plugin.SatControl
{
    partial class SatControlPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkRigEnable = new System.Windows.Forms.CheckBox();
            this.cbRig = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRigName = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblFrequency = new System.Windows.Forms.Label();
            this.lblMode = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.bb_omniRigConfig = new System.Windows.Forms.Button();
            this.cbSateList = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAzimuth = new System.Windows.Forms.Label();
            this.lblElevation = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.cbTransmitter = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LabelT = new System.Windows.Forms.Label();
            this.lblRx = new System.Windows.Forms.Label();
            this.lblTx = new System.Windows.Forms.Label();
            this.lblSatMode = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblDoppler = new System.Windows.Forms.Label();
            this.lblTxDoppler = new System.Windows.Forms.Label();
            this.lblRxDoppler = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.chkSatEnable = new System.Windows.Forms.CheckBox();
            this.bb_satReset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bb_rigCW = new System.Windows.Forms.Button();
            this.bb_rigUSB = new System.Windows.Forms.Button();
            this.bb_rigLSB = new System.Windows.Forms.Button();
            this.bb_rigFM = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.nudTxOffset = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMaxEl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblAos = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblRotMsg = new System.Windows.Forms.Label();
            this.lblRotorEl = new System.Windows.Forms.Label();
            this.lblRotorAz = new System.Windows.Forms.Label();
            this.bbRotorRight = new System.Windows.Forms.Button();
            this.bbRotorLeft = new System.Windows.Forms.Button();
            this.bbRotorDn = new System.Windows.Forms.Button();
            this.bbRotorUp = new System.Windows.Forms.Button();
            this.chkRotorEnable = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTxOffset)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkRigEnable
            // 
            this.chkRigEnable.AutoSize = true;
            this.chkRigEnable.Location = new System.Drawing.Point(6, 18);
            this.chkRigEnable.Name = "chkRigEnable";
            this.chkRigEnable.Size = new System.Drawing.Size(61, 19);
            this.chkRigEnable.TabIndex = 0;
            this.chkRigEnable.Text = "Enable";
            this.chkRigEnable.UseVisualStyleBackColor = true;
            this.chkRigEnable.CheckedChanged += new System.EventHandler(this.chkRigEnable_CheckedChanged);
            // 
            // cbRig
            // 
            this.cbRig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRig.FormattingEnabled = true;
            this.cbRig.Location = new System.Drawing.Point(6, 41);
            this.cbRig.Name = "cbRig";
            this.cbRig.Size = new System.Drawing.Size(69, 23);
            this.cbRig.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(5, 72);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(56, 15);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "RigName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Frequency";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mode";
            // 
            // lblRigName
            // 
            this.lblRigName.AutoSize = true;
            this.lblRigName.Location = new System.Drawing.Point(85, 72);
            this.lblRigName.Name = "lblRigName";
            this.lblRigName.Size = new System.Drawing.Size(38, 15);
            this.lblRigName.TabIndex = 7;
            this.lblRigName.Text = "label6";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(85, 87);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(38, 15);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "label7";
            // 
            // lblFrequency
            // 
            this.lblFrequency.AutoSize = true;
            this.lblFrequency.Location = new System.Drawing.Point(85, 102);
            this.lblFrequency.Name = "lblFrequency";
            this.lblFrequency.Size = new System.Drawing.Size(38, 15);
            this.lblFrequency.TabIndex = 9;
            this.lblFrequency.Text = "label8";
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Location = new System.Drawing.Point(85, 117);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(38, 15);
            this.lblMode.TabIndex = 10;
            this.lblMode.Text = "label9";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(108, 644);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(45, 15);
            this.lblVersion.TabIndex = 11;
            this.lblVersion.Text = "version";
            // 
            // bb_omniRigConfig
            // 
            this.bb_omniRigConfig.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bb_omniRigConfig.Location = new System.Drawing.Point(85, 40);
            this.bb_omniRigConfig.Name = "bb_omniRigConfig";
            this.bb_omniRigConfig.Size = new System.Drawing.Size(51, 24);
            this.bb_omniRigConfig.TabIndex = 12;
            this.bb_omniRigConfig.Text = "Config";
            this.bb_omniRigConfig.UseVisualStyleBackColor = true;
            this.bb_omniRigConfig.Click += new System.EventHandler(this.bb_omniRigConfig_Click);
            // 
            // cbSateList
            // 
            this.cbSateList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSateList.FormattingEnabled = true;
            this.cbSateList.Location = new System.Drawing.Point(6, 44);
            this.cbSateList.Name = "cbSateList";
            this.cbSateList.Size = new System.Drawing.Size(206, 23);
            this.cbSateList.TabIndex = 13;
            this.cbSateList.SelectedIndexChanged += new System.EventHandler(this.cbSateList_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Azimuth";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Elevation";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Distance";
            // 
            // lblAzimuth
            // 
            this.lblAzimuth.AutoSize = true;
            this.lblAzimuth.Location = new System.Drawing.Point(85, 70);
            this.lblAzimuth.Name = "lblAzimuth";
            this.lblAzimuth.Size = new System.Drawing.Size(38, 15);
            this.lblAzimuth.TabIndex = 17;
            this.lblAzimuth.Text = "label9";
            // 
            // lblElevation
            // 
            this.lblElevation.AutoSize = true;
            this.lblElevation.Location = new System.Drawing.Point(85, 85);
            this.lblElevation.Name = "lblElevation";
            this.lblElevation.Size = new System.Drawing.Size(44, 15);
            this.lblElevation.TabIndex = 18;
            this.lblElevation.Text = "label10";
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(85, 100);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(44, 15);
            this.lblDistance.TabIndex = 19;
            this.lblDistance.Text = "label11";
            // 
            // cbTransmitter
            // 
            this.cbTransmitter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTransmitter.FormattingEnabled = true;
            this.cbTransmitter.Location = new System.Drawing.Point(7, 167);
            this.cbTransmitter.Name = "cbTransmitter";
            this.cbTransmitter.Size = new System.Drawing.Size(205, 23);
            this.cbTransmitter.TabIndex = 22;
            this.cbTransmitter.SelectedIndexChanged += new System.EventHandler(this.cbTransmitter_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "Downlink";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 15);
            this.label11.TabIndex = 24;
            this.label11.Text = "Uplink";
            // 
            // LabelT
            // 
            this.LabelT.AutoSize = true;
            this.LabelT.Location = new System.Drawing.Point(8, 224);
            this.LabelT.Name = "LabelT";
            this.LabelT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelT.Size = new System.Drawing.Size(38, 15);
            this.LabelT.TabIndex = 25;
            this.LabelT.Text = "Mode";
            // 
            // lblRx
            // 
            this.lblRx.AutoSize = true;
            this.lblRx.Location = new System.Drawing.Point(85, 193);
            this.lblRx.Name = "lblRx";
            this.lblRx.Size = new System.Drawing.Size(44, 15);
            this.lblRx.TabIndex = 26;
            this.lblRx.Text = "label13";
            // 
            // lblTx
            // 
            this.lblTx.AutoSize = true;
            this.lblTx.Location = new System.Drawing.Point(85, 208);
            this.lblTx.Name = "lblTx";
            this.lblTx.Size = new System.Drawing.Size(44, 15);
            this.lblTx.TabIndex = 27;
            this.lblTx.Text = "label14";
            // 
            // lblSatMode
            // 
            this.lblSatMode.AutoSize = true;
            this.lblSatMode.Location = new System.Drawing.Point(85, 224);
            this.lblSatMode.Name = "lblSatMode";
            this.lblSatMode.Size = new System.Drawing.Size(44, 15);
            this.lblSatMode.TabIndex = 28;
            this.lblSatMode.Text = "label15";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 15);
            this.label9.TabIndex = 29;
            this.label9.Text = "Doppler";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(6, 287);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 21);
            this.label12.TabIndex = 30;
            this.label12.Text = "Radio Tx";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(6, 266);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 21);
            this.label13.TabIndex = 31;
            this.label13.Text = "Radio Rx";
            // 
            // lblDoppler
            // 
            this.lblDoppler.AutoSize = true;
            this.lblDoppler.Location = new System.Drawing.Point(85, 251);
            this.lblDoppler.Name = "lblDoppler";
            this.lblDoppler.Size = new System.Drawing.Size(44, 15);
            this.lblDoppler.TabIndex = 32;
            this.lblDoppler.Text = "label14";
            // 
            // lblTxDoppler
            // 
            this.lblTxDoppler.AutoSize = true;
            this.lblTxDoppler.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTxDoppler.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTxDoppler.Location = new System.Drawing.Point(84, 287);
            this.lblTxDoppler.Name = "lblTxDoppler";
            this.lblTxDoppler.Size = new System.Drawing.Size(66, 21);
            this.lblTxDoppler.TabIndex = 33;
            this.lblTxDoppler.Text = "label15";
            // 
            // lblRxDoppler
            // 
            this.lblRxDoppler.AutoSize = true;
            this.lblRxDoppler.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRxDoppler.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRxDoppler.Location = new System.Drawing.Point(84, 266);
            this.lblRxDoppler.Name = "lblRxDoppler";
            this.lblRxDoppler.Size = new System.Drawing.Size(66, 21);
            this.lblRxDoppler.TabIndex = 34;
            this.lblRxDoppler.Text = "label16";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 115);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 15);
            this.label14.TabIndex = 35;
            this.label14.Text = "Speed";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(85, 115);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(44, 15);
            this.lblSpeed.TabIndex = 36;
            this.lblSpeed.Text = "label15";
            // 
            // chkSatEnable
            // 
            this.chkSatEnable.AutoSize = true;
            this.chkSatEnable.Location = new System.Drawing.Point(6, 19);
            this.chkSatEnable.Name = "chkSatEnable";
            this.chkSatEnable.Size = new System.Drawing.Size(61, 19);
            this.chkSatEnable.TabIndex = 37;
            this.chkSatEnable.Text = "Enable";
            this.chkSatEnable.UseVisualStyleBackColor = true;
            this.chkSatEnable.CheckedChanged += new System.EventHandler(this.chkSatEnable_CheckedChanged);
            // 
            // bb_satReset
            // 
            this.bb_satReset.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bb_satReset.Location = new System.Drawing.Point(160, 315);
            this.bb_satReset.Name = "bb_satReset";
            this.bb_satReset.Size = new System.Drawing.Size(52, 22);
            this.bb_satReset.TabIndex = 38;
            this.bb_satReset.Text = "Reset ";
            this.bb_satReset.UseVisualStyleBackColor = true;
            this.bb_satReset.Click += new System.EventHandler(this.bb_satReset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bb_rigCW);
            this.groupBox1.Controls.Add(this.bb_rigUSB);
            this.groupBox1.Controls.Add(this.bb_rigLSB);
            this.groupBox1.Controls.Add(this.bb_rigFM);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.nudTxOffset);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.bb_omniRigConfig);
            this.groupBox1.Controls.Add(this.lblMode);
            this.groupBox1.Controls.Add(this.lblFrequency);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.lblRigName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Label1);
            this.groupBox1.Controls.Add(this.cbRig);
            this.groupBox1.Controls.Add(this.chkRigEnable);
            this.groupBox1.Location = new System.Drawing.Point(3, 352);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 194);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Radio Control";
            // 
            // bb_rigCW
            // 
            this.bb_rigCW.Location = new System.Drawing.Point(174, 152);
            this.bb_rigCW.Name = "bb_rigCW";
            this.bb_rigCW.Size = new System.Drawing.Size(38, 23);
            this.bb_rigCW.TabIndex = 23;
            this.bb_rigCW.Text = "CW";
            this.bb_rigCW.UseVisualStyleBackColor = true;
            this.bb_rigCW.Click += new System.EventHandler(this.bb_rigCW_Click);
            // 
            // bb_rigUSB
            // 
            this.bb_rigUSB.Location = new System.Drawing.Point(174, 122);
            this.bb_rigUSB.Name = "bb_rigUSB";
            this.bb_rigUSB.Size = new System.Drawing.Size(37, 23);
            this.bb_rigUSB.TabIndex = 22;
            this.bb_rigUSB.Text = "USB";
            this.bb_rigUSB.UseVisualStyleBackColor = true;
            this.bb_rigUSB.Click += new System.EventHandler(this.bb_rigUSB_Click);
            // 
            // bb_rigLSB
            // 
            this.bb_rigLSB.Location = new System.Drawing.Point(174, 93);
            this.bb_rigLSB.Name = "bb_rigLSB";
            this.bb_rigLSB.Size = new System.Drawing.Size(37, 23);
            this.bb_rigLSB.TabIndex = 21;
            this.bb_rigLSB.Text = "LSB";
            this.bb_rigLSB.UseVisualStyleBackColor = true;
            this.bb_rigLSB.Click += new System.EventHandler(this.bb_rigLSB_Click);
            // 
            // bb_rigFM
            // 
            this.bb_rigFM.Location = new System.Drawing.Point(174, 64);
            this.bb_rigFM.Name = "bb_rigFM";
            this.bb_rigFM.Size = new System.Drawing.Size(37, 23);
            this.bb_rigFM.TabIndex = 20;
            this.bb_rigFM.Text = "FM";
            this.bb_rigFM.UseVisualStyleBackColor = true;
            this.bb_rigFM.Click += new System.EventHandler(this.bb_rigFM_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(2, 142);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(118, 15);
            this.label16.TabIndex = 19;
            this.label16.Text = "Transverter / Delta TX";
            // 
            // nudTxOffset
            // 
            this.nudTxOffset.Location = new System.Drawing.Point(5, 160);
            this.nudTxOffset.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudTxOffset.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            -2147483648});
            this.nudTxOffset.Name = "nudTxOffset";
            this.nudTxOffset.Size = new System.Drawing.Size(84, 23);
            this.nudTxOffset.TabIndex = 18;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(95, 168);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 15);
            this.label15.TabIndex = 15;
            this.label15.Text = "Hz";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMaxEl);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.lblAos);
            this.groupBox2.Controls.Add(this.bb_satReset);
            this.groupBox2.Controls.Add(this.chkSatEnable);
            this.groupBox2.Controls.Add(this.lblSpeed);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.lblRxDoppler);
            this.groupBox2.Controls.Add(this.lblTxDoppler);
            this.groupBox2.Controls.Add(this.lblDoppler);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblSatMode);
            this.groupBox2.Controls.Add(this.lblTx);
            this.groupBox2.Controls.Add(this.lblRx);
            this.groupBox2.Controls.Add(this.LabelT);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cbTransmitter);
            this.groupBox2.Controls.Add(this.lblDistance);
            this.groupBox2.Controls.Add(this.lblElevation);
            this.groupBox2.Controls.Add(this.lblAzimuth);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbSateList);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 347);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Satellite Control";
            // 
            // lblMaxEl
            // 
            this.lblMaxEl.AutoSize = true;
            this.lblMaxEl.Location = new System.Drawing.Point(85, 146);
            this.lblMaxEl.Name = "lblMaxEl";
            this.lblMaxEl.Size = new System.Drawing.Size(44, 15);
            this.lblMaxEl.TabIndex = 42;
            this.lblMaxEl.Text = "label20";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 41;
            this.label5.Text = "Max El";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 131);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(75, 15);
            this.label19.TabIndex = 40;
            this.label19.Text = "AOS / LOS in";
            // 
            // lblAos
            // 
            this.lblAos.AutoSize = true;
            this.lblAos.Location = new System.Drawing.Point(84, 130);
            this.lblAos.Name = "lblAos";
            this.lblAos.Size = new System.Drawing.Size(44, 15);
            this.lblAos.TabIndex = 39;
            this.lblAos.Text = "label19";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblRotMsg);
            this.groupBox3.Controls.Add(this.lblRotorEl);
            this.groupBox3.Controls.Add(this.lblRotorAz);
            this.groupBox3.Controls.Add(this.bbRotorRight);
            this.groupBox3.Controls.Add(this.bbRotorLeft);
            this.groupBox3.Controls.Add(this.bbRotorDn);
            this.groupBox3.Controls.Add(this.bbRotorUp);
            this.groupBox3.Controls.Add(this.chkRotorEnable);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Location = new System.Drawing.Point(3, 552);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(217, 89);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rotor Control";
            // 
            // lblRotMsg
            // 
            this.lblRotMsg.AutoSize = true;
            this.lblRotMsg.Location = new System.Drawing.Point(5, 71);
            this.lblRotMsg.Name = "lblRotMsg";
            this.lblRotMsg.Size = new System.Drawing.Size(44, 15);
            this.lblRotMsg.TabIndex = 9;
            this.lblRotMsg.Text = "label19";
            // 
            // lblRotorEl
            // 
            this.lblRotorEl.AutoSize = true;
            this.lblRotorEl.Location = new System.Drawing.Point(30, 55);
            this.lblRotorEl.Name = "lblRotorEl";
            this.lblRotorEl.Size = new System.Drawing.Size(44, 15);
            this.lblRotorEl.TabIndex = 8;
            this.lblRotorEl.Text = "label20";
            // 
            // lblRotorAz
            // 
            this.lblRotorAz.AutoSize = true;
            this.lblRotorAz.Location = new System.Drawing.Point(31, 40);
            this.lblRotorAz.Name = "lblRotorAz";
            this.lblRotorAz.Size = new System.Drawing.Size(44, 15);
            this.lblRotorAz.TabIndex = 7;
            this.lblRotorAz.Text = "label19";
            // 
            // bbRotorRight
            // 
            this.bbRotorRight.Location = new System.Drawing.Point(165, 51);
            this.bbRotorRight.Name = "bbRotorRight";
            this.bbRotorRight.Size = new System.Drawing.Size(46, 23);
            this.bbRotorRight.TabIndex = 6;
            this.bbRotorRight.Text = "Right";
            this.bbRotorRight.UseVisualStyleBackColor = true;
            this.bbRotorRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bbRotorRight_MouseDown);
            this.bbRotorRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bbRotorRight_MouseUp);
            // 
            // bbRotorLeft
            // 
            this.bbRotorLeft.Location = new System.Drawing.Point(113, 51);
            this.bbRotorLeft.Name = "bbRotorLeft";
            this.bbRotorLeft.Size = new System.Drawing.Size(46, 23);
            this.bbRotorLeft.TabIndex = 5;
            this.bbRotorLeft.Text = "Left";
            this.bbRotorLeft.UseVisualStyleBackColor = true;
            this.bbRotorLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bbRotorLeft_MouseDown);
            this.bbRotorLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bbRotorLeft_MouseUp);
            // 
            // bbRotorDn
            // 
            this.bbRotorDn.Location = new System.Drawing.Point(113, 22);
            this.bbRotorDn.Name = "bbRotorDn";
            this.bbRotorDn.Size = new System.Drawing.Size(46, 23);
            this.bbRotorDn.TabIndex = 4;
            this.bbRotorDn.Text = "Dn";
            this.bbRotorDn.UseVisualStyleBackColor = true;
            this.bbRotorDn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bbRotorDn_MouseDown);
            this.bbRotorDn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bbRotorDn_MouseUp);
            // 
            // bbRotorUp
            // 
            this.bbRotorUp.Location = new System.Drawing.Point(165, 22);
            this.bbRotorUp.Name = "bbRotorUp";
            this.bbRotorUp.Size = new System.Drawing.Size(46, 23);
            this.bbRotorUp.TabIndex = 3;
            this.bbRotorUp.Text = "Up";
            this.bbRotorUp.UseVisualStyleBackColor = true;
            this.bbRotorUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bbRotorUp_MouseDown);
            this.bbRotorUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bbRotorUp_MouseUp);
            // 
            // chkRotorEnable
            // 
            this.chkRotorEnable.AutoSize = true;
            this.chkRotorEnable.Location = new System.Drawing.Point(6, 18);
            this.chkRotorEnable.Name = "chkRotorEnable";
            this.chkRotorEnable.Size = new System.Drawing.Size(61, 19);
            this.chkRotorEnable.TabIndex = 2;
            this.chkRotorEnable.Text = "Enable";
            this.chkRotorEnable.UseVisualStyleBackColor = true;
            this.chkRotorEnable.CheckedChanged += new System.EventHandler(this.chkRotorEnable_CheckedChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(5, 55);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(16, 15);
            this.label18.TabIndex = 1;
            this.label18.Text = "El";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(5, 40);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(20, 15);
            this.label17.TabIndex = 0;
            this.label17.Text = "Az";
            // 
            // SatControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblVersion);
            this.Name = "SatControlPanel";
            this.Size = new System.Drawing.Size(225, 671);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTxOffset)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkRigEnable;
        private System.Windows.Forms.ComboBox cbRig;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRigName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblFrequency;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button bb_omniRigConfig;
        private System.Windows.Forms.ComboBox cbSateList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAzimuth;
        private System.Windows.Forms.Label lblElevation;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.ComboBox cbTransmitter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LabelT;
        private System.Windows.Forms.Label lblRx;
        private System.Windows.Forms.Label lblTx;
        private System.Windows.Forms.Label lblSatMode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblDoppler;
        private System.Windows.Forms.Label lblTxDoppler;
        private System.Windows.Forms.Label lblRxDoppler;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.CheckBox chkSatEnable;
        private System.Windows.Forms.Button bb_satReset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown nudTxOffset;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblRotorEl;
        private System.Windows.Forms.Label lblRotorAz;
        private System.Windows.Forms.Button bbRotorRight;
        private System.Windows.Forms.Button bbRotorLeft;
        private System.Windows.Forms.Button bbRotorDn;
        private System.Windows.Forms.Button bbRotorUp;
        private System.Windows.Forms.CheckBox chkRotorEnable;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblRotMsg;
        private System.Windows.Forms.Button bb_rigCW;
        private System.Windows.Forms.Button bb_rigUSB;
        private System.Windows.Forms.Button bb_rigLSB;
        private System.Windows.Forms.Button bb_rigFM;
        private System.Windows.Forms.Label lblAos;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblMaxEl;
    }
}