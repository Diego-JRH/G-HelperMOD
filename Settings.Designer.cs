﻿namespace GHelper
{
    partial class SettingsForm
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
            this.checkStartup = new System.Windows.Forms.CheckBox();
            this.trackBattery = new System.Windows.Forms.TrackBar();
            this.labelBattery = new System.Windows.Forms.Label();
            this.labelBatteryLimit = new System.Windows.Forms.Label();
            this.pictureBattery = new System.Windows.Forms.PictureBox();
            this.labelGPUFan = new System.Windows.Forms.Label();
            this.tableGPU = new System.Windows.Forms.TableLayoutPanel();
            this.buttonUltimate = new System.Windows.Forms.Button();
            this.buttonStandard = new System.Windows.Forms.Button();
            this.buttonEco = new System.Windows.Forms.Button();
            this.labelGPU = new System.Windows.Forms.Label();
            this.pictureGPU = new System.Windows.Forms.PictureBox();
            this.labelCPUFan = new System.Windows.Forms.Label();
            this.tablePerf = new System.Windows.Forms.TableLayoutPanel();
            this.buttonTurbo = new System.Windows.Forms.Button();
            this.buttonBalanced = new System.Windows.Forms.Button();
            this.buttonSilent = new System.Windows.Forms.Button();
            this.picturePerf = new System.Windows.Forms.PictureBox();
            this.labelPerf = new System.Windows.Forms.Label();
            this.checkGPU = new System.Windows.Forms.CheckBox();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.pictureScreen = new System.Windows.Forms.PictureBox();
            this.labelSreen = new System.Windows.Forms.Label();
            this.tableScreen = new System.Windows.Forms.TableLayoutPanel();
            this.button120Hz = new System.Windows.Forms.Button();
            this.button60Hz = new System.Windows.Forms.Button();
            this.checkScreen = new System.Windows.Forms.CheckBox();
            this.checkBoost = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBattery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBattery)).BeginInit();
            this.tableGPU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGPU)).BeginInit();
            this.tablePerf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePerf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureScreen)).BeginInit();
            this.tableScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkStartup
            // 
            this.checkStartup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkStartup.AutoSize = true;
            this.checkStartup.Location = new System.Drawing.Point(18, 409);
            this.checkStartup.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.checkStartup.Name = "checkStartup";
            this.checkStartup.Size = new System.Drawing.Size(105, 19);
            this.checkStartup.TabIndex = 2;
            this.checkStartup.Text = "Run on Startup";
            this.checkStartup.UseVisualStyleBackColor = true;
            this.checkStartup.CheckedChanged += new System.EventHandler(this.checkStartup_CheckedChanged);
            // 
            // trackBattery
            // 
            this.trackBattery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBattery.LargeChange = 20;
            this.trackBattery.Location = new System.Drawing.Point(12, 359);
            this.trackBattery.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.trackBattery.Maximum = 100;
            this.trackBattery.Minimum = 50;
            this.trackBattery.Name = "trackBattery";
            this.trackBattery.Size = new System.Drawing.Size(361, 45);
            this.trackBattery.SmallChange = 10;
            this.trackBattery.TabIndex = 3;
            this.trackBattery.TickFrequency = 10;
            this.trackBattery.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBattery.Value = 100;
            // 
            // labelBattery
            // 
            this.labelBattery.AutoSize = true;
            this.labelBattery.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBattery.Location = new System.Drawing.Point(45, 339);
            this.labelBattery.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBattery.Name = "labelBattery";
            this.labelBattery.Size = new System.Drawing.Size(122, 15);
            this.labelBattery.TabIndex = 4;
            this.labelBattery.Text = "Battery Charge Limit";
            // 
            // labelBatteryLimit
            // 
            this.labelBatteryLimit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBatteryLimit.AutoSize = true;
            this.labelBatteryLimit.Location = new System.Drawing.Point(331, 338);
            this.labelBatteryLimit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBatteryLimit.Name = "labelBatteryLimit";
            this.labelBatteryLimit.Size = new System.Drawing.Size(35, 15);
            this.labelBatteryLimit.TabIndex = 5;
            this.labelBatteryLimit.Text = "100%";
            // 
            // pictureBattery
            // 
            this.pictureBattery.BackgroundImage = global::GHelper.Properties.Resources.icons8_charging_battery_48;
            this.pictureBattery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBattery.Location = new System.Drawing.Point(17, 335);
            this.pictureBattery.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBattery.Name = "pictureBattery";
            this.pictureBattery.Size = new System.Drawing.Size(26, 22);
            this.pictureBattery.TabIndex = 6;
            this.pictureBattery.TabStop = false;
            // 
            // labelGPUFan
            // 
            this.labelGPUFan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGPUFan.AutoSize = true;
            this.labelGPUFan.Location = new System.Drawing.Point(293, 123);
            this.labelGPUFan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGPUFan.Name = "labelGPUFan";
            this.labelGPUFan.Size = new System.Drawing.Size(77, 15);
            this.labelGPUFan.TabIndex = 8;
            this.labelGPUFan.Text = "GPU Fan : 0%";
            // 
            // tableGPU
            // 
            this.tableGPU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableGPU.ColumnCount = 3;
            this.tableGPU.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableGPU.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableGPU.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableGPU.Controls.Add(this.buttonUltimate, 2, 0);
            this.tableGPU.Controls.Add(this.buttonStandard, 1, 0);
            this.tableGPU.Controls.Add(this.buttonEco, 0, 0);
            this.tableGPU.Location = new System.Drawing.Point(12, 142);
            this.tableGPU.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tableGPU.Name = "tableGPU";
            this.tableGPU.RowCount = 1;
            this.tableGPU.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableGPU.Size = new System.Drawing.Size(361, 50);
            this.tableGPU.TabIndex = 7;
            // 
            // buttonUltimate
            // 
            this.buttonUltimate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonUltimate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonUltimate.FlatAppearance.BorderSize = 0;
            this.buttonUltimate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUltimate.Location = new System.Drawing.Point(245, 5);
            this.buttonUltimate.Margin = new System.Windows.Forms.Padding(5);
            this.buttonUltimate.Name = "buttonUltimate";
            this.buttonUltimate.Size = new System.Drawing.Size(111, 40);
            this.buttonUltimate.TabIndex = 2;
            this.buttonUltimate.Text = "Ultimate";
            this.buttonUltimate.UseVisualStyleBackColor = false;
            // 
            // buttonStandard
            // 
            this.buttonStandard.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonStandard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonStandard.FlatAppearance.BorderSize = 0;
            this.buttonStandard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStandard.Location = new System.Drawing.Point(125, 5);
            this.buttonStandard.Margin = new System.Windows.Forms.Padding(5);
            this.buttonStandard.Name = "buttonStandard";
            this.buttonStandard.Size = new System.Drawing.Size(110, 40);
            this.buttonStandard.TabIndex = 1;
            this.buttonStandard.Text = "Standard";
            this.buttonStandard.UseVisualStyleBackColor = false;
            // 
            // buttonEco
            // 
            this.buttonEco.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEco.CausesValidation = false;
            this.buttonEco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEco.FlatAppearance.BorderSize = 0;
            this.buttonEco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEco.Location = new System.Drawing.Point(5, 5);
            this.buttonEco.Margin = new System.Windows.Forms.Padding(5);
            this.buttonEco.Name = "buttonEco";
            this.buttonEco.Size = new System.Drawing.Size(110, 40);
            this.buttonEco.TabIndex = 0;
            this.buttonEco.Text = "Eco";
            this.buttonEco.UseVisualStyleBackColor = false;
            // 
            // labelGPU
            // 
            this.labelGPU.AutoSize = true;
            this.labelGPU.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGPU.Location = new System.Drawing.Point(45, 124);
            this.labelGPU.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGPU.Name = "labelGPU";
            this.labelGPU.Size = new System.Drawing.Size(67, 15);
            this.labelGPU.TabIndex = 9;
            this.labelGPU.Text = "GPU Mode";
            // 
            // pictureGPU
            // 
            this.pictureGPU.BackgroundImage = global::GHelper.Properties.Resources.icons8_video_card_48;
            this.pictureGPU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureGPU.Location = new System.Drawing.Point(17, 120);
            this.pictureGPU.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureGPU.Name = "pictureGPU";
            this.pictureGPU.Size = new System.Drawing.Size(26, 22);
            this.pictureGPU.TabIndex = 10;
            this.pictureGPU.TabStop = false;
            // 
            // labelCPUFan
            // 
            this.labelCPUFan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCPUFan.AutoSize = true;
            this.labelCPUFan.Location = new System.Drawing.Point(293, 18);
            this.labelCPUFan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCPUFan.Name = "labelCPUFan";
            this.labelCPUFan.Size = new System.Drawing.Size(77, 15);
            this.labelCPUFan.TabIndex = 12;
            this.labelCPUFan.Text = "CPU Fan : 0%";
            // 
            // tablePerf
            // 
            this.tablePerf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePerf.ColumnCount = 3;
            this.tablePerf.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tablePerf.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tablePerf.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tablePerf.Controls.Add(this.buttonTurbo, 2, 0);
            this.tablePerf.Controls.Add(this.buttonBalanced, 1, 0);
            this.tablePerf.Controls.Add(this.buttonSilent, 0, 0);
            this.tablePerf.Location = new System.Drawing.Point(12, 37);
            this.tablePerf.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tablePerf.Name = "tablePerf";
            this.tablePerf.RowCount = 1;
            this.tablePerf.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tablePerf.Size = new System.Drawing.Size(361, 50);
            this.tablePerf.TabIndex = 11;
            // 
            // buttonTurbo
            // 
            this.buttonTurbo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonTurbo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonTurbo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonTurbo.FlatAppearance.BorderSize = 0;
            this.buttonTurbo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTurbo.Location = new System.Drawing.Point(245, 5);
            this.buttonTurbo.Margin = new System.Windows.Forms.Padding(5);
            this.buttonTurbo.Name = "buttonTurbo";
            this.buttonTurbo.Size = new System.Drawing.Size(111, 40);
            this.buttonTurbo.TabIndex = 2;
            this.buttonTurbo.Text = "Turbo";
            this.buttonTurbo.UseVisualStyleBackColor = false;
            // 
            // buttonBalanced
            // 
            this.buttonBalanced.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBalanced.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBalanced.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonBalanced.FlatAppearance.BorderSize = 0;
            this.buttonBalanced.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBalanced.Location = new System.Drawing.Point(125, 5);
            this.buttonBalanced.Margin = new System.Windows.Forms.Padding(5);
            this.buttonBalanced.Name = "buttonBalanced";
            this.buttonBalanced.Size = new System.Drawing.Size(110, 40);
            this.buttonBalanced.TabIndex = 1;
            this.buttonBalanced.Text = "Balanced";
            this.buttonBalanced.UseVisualStyleBackColor = false;
            // 
            // buttonSilent
            // 
            this.buttonSilent.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSilent.CausesValidation = false;
            this.buttonSilent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSilent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonSilent.FlatAppearance.BorderSize = 0;
            this.buttonSilent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSilent.Location = new System.Drawing.Point(5, 5);
            this.buttonSilent.Margin = new System.Windows.Forms.Padding(5);
            this.buttonSilent.Name = "buttonSilent";
            this.buttonSilent.Size = new System.Drawing.Size(110, 40);
            this.buttonSilent.TabIndex = 0;
            this.buttonSilent.Text = "Silent";
            this.buttonSilent.UseVisualStyleBackColor = false;
            // 
            // picturePerf
            // 
            this.picturePerf.BackgroundImage = global::GHelper.Properties.Resources.icons8_speed_48;
            this.picturePerf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picturePerf.InitialImage = null;
            this.picturePerf.Location = new System.Drawing.Point(17, 15);
            this.picturePerf.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.picturePerf.Name = "picturePerf";
            this.picturePerf.Size = new System.Drawing.Size(26, 22);
            this.picturePerf.TabIndex = 14;
            this.picturePerf.TabStop = false;
            // 
            // labelPerf
            // 
            this.labelPerf.AutoSize = true;
            this.labelPerf.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPerf.Location = new System.Drawing.Point(45, 19);
            this.labelPerf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPerf.Name = "labelPerf";
            this.labelPerf.Size = new System.Drawing.Size(115, 15);
            this.labelPerf.TabIndex = 13;
            this.labelPerf.Text = "Performance Mode";
            // 
            // checkGPU
            // 
            this.checkGPU.AutoSize = true;
            this.checkGPU.ForeColor = System.Drawing.SystemColors.GrayText;
            this.checkGPU.Location = new System.Drawing.Point(18, 192);
            this.checkGPU.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.checkGPU.Name = "checkGPU";
            this.checkGPU.Size = new System.Drawing.Size(273, 19);
            this.checkGPU.TabIndex = 15;
            this.checkGPU.Text = "Set Eco on battery and Standard when plugged";
            this.checkGPU.UseVisualStyleBackColor = true;
            this.checkGPU.CheckedChanged += new System.EventHandler(this.checkGPU_CheckedChanged);
            // 
            // buttonQuit
            // 
            this.buttonQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonQuit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonQuit.Location = new System.Drawing.Point(307, 409);
            this.buttonQuit.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(65, 22);
            this.buttonQuit.TabIndex = 16;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = false;
            // 
            // pictureScreen
            // 
            this.pictureScreen.BackgroundImage = global::GHelper.Properties.Resources.icons8_laptop_48;
            this.pictureScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureScreen.Location = new System.Drawing.Point(17, 229);
            this.pictureScreen.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureScreen.Name = "pictureScreen";
            this.pictureScreen.Size = new System.Drawing.Size(26, 22);
            this.pictureScreen.TabIndex = 18;
            this.pictureScreen.TabStop = false;
            // 
            // labelSreen
            // 
            this.labelSreen.AutoSize = true;
            this.labelSreen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSreen.Location = new System.Drawing.Point(45, 233);
            this.labelSreen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSreen.Name = "labelSreen";
            this.labelSreen.Size = new System.Drawing.Size(87, 15);
            this.labelSreen.TabIndex = 17;
            this.labelSreen.Text = "Laptop Screen";
            // 
            // tableScreen
            // 
            this.tableScreen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableScreen.ColumnCount = 3;
            this.tableScreen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableScreen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableScreen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableScreen.Controls.Add(this.button120Hz, 1, 0);
            this.tableScreen.Controls.Add(this.button60Hz, 0, 0);
            this.tableScreen.Location = new System.Drawing.Point(12, 251);
            this.tableScreen.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tableScreen.Name = "tableScreen";
            this.tableScreen.RowCount = 1;
            this.tableScreen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableScreen.Size = new System.Drawing.Size(361, 48);
            this.tableScreen.TabIndex = 19;
            // 
            // button120Hz
            // 
            this.button120Hz.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button120Hz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button120Hz.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.button120Hz.FlatAppearance.BorderSize = 0;
            this.button120Hz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button120Hz.Location = new System.Drawing.Point(125, 5);
            this.button120Hz.Margin = new System.Windows.Forms.Padding(5);
            this.button120Hz.Name = "button120Hz";
            this.button120Hz.Size = new System.Drawing.Size(110, 40);
            this.button120Hz.TabIndex = 1;
            this.button120Hz.Text = "120Hz + OD";
            this.button120Hz.UseVisualStyleBackColor = false;
            // 
            // button60Hz
            // 
            this.button60Hz.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button60Hz.CausesValidation = false;
            this.button60Hz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button60Hz.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.button60Hz.FlatAppearance.BorderSize = 0;
            this.button60Hz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button60Hz.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button60Hz.Location = new System.Drawing.Point(5, 5);
            this.button60Hz.Margin = new System.Windows.Forms.Padding(5);
            this.button60Hz.Name = "button60Hz";
            this.button60Hz.Size = new System.Drawing.Size(110, 40);
            this.button60Hz.TabIndex = 0;
            this.button60Hz.Text = "60Hz";
            this.button60Hz.UseVisualStyleBackColor = false;
            // 
            // checkScreen
            // 
            this.checkScreen.AutoSize = true;
            this.checkScreen.ForeColor = System.Drawing.SystemColors.GrayText;
            this.checkScreen.Location = new System.Drawing.Point(18, 299);
            this.checkScreen.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.checkScreen.Name = "checkScreen";
            this.checkScreen.Size = new System.Drawing.Size(261, 19);
            this.checkScreen.TabIndex = 20;
            this.checkScreen.Text = "Set 60Hz on battery, and back when plugged";
            this.checkScreen.UseVisualStyleBackColor = true;
            // 
            // checkBoost
            // 
            this.checkBoost.AutoSize = true;
            this.checkBoost.ForeColor = System.Drawing.SystemColors.GrayText;
            this.checkBoost.Location = new System.Drawing.Point(18, 87);
            this.checkBoost.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.checkBoost.Name = "checkBoost";
            this.checkBoost.Size = new System.Drawing.Size(127, 19);
            this.checkBoost.TabIndex = 21;
            this.checkBoost.Text = "CPU Boost enabled";
            this.checkBoost.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 441);
            this.Controls.Add(this.checkBoost);
            this.Controls.Add(this.checkScreen);
            this.Controls.Add(this.tableScreen);
            this.Controls.Add(this.pictureScreen);
            this.Controls.Add(this.labelSreen);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.checkGPU);
            this.Controls.Add(this.picturePerf);
            this.Controls.Add(this.labelPerf);
            this.Controls.Add(this.labelCPUFan);
            this.Controls.Add(this.tablePerf);
            this.Controls.Add(this.pictureGPU);
            this.Controls.Add(this.labelGPU);
            this.Controls.Add(this.labelGPUFan);
            this.Controls.Add(this.tableGPU);
            this.Controls.Add(this.pictureBattery);
            this.Controls.Add(this.labelBatteryLimit);
            this.Controls.Add(this.labelBattery);
            this.Controls.Add(this.trackBattery);
            this.Controls.Add(this.checkStartup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "G14 Helper";
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBattery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBattery)).EndInit();
            this.tableGPU.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureGPU)).EndInit();
            this.tablePerf.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturePerf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureScreen)).EndInit();
            this.tableScreen.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CheckBox checkStartup;
        private TrackBar trackBattery;
        private Label labelBattery;
        private Label labelBatteryLimit;
        private PictureBox pictureBattery;
        private Label labelGPUFan;
        private TableLayoutPanel tableGPU;
        private Button buttonUltimate;
        private Button buttonStandard;
        private Button buttonEco;
        private Label labelGPU;
        private PictureBox pictureGPU;
        private Label labelCPUFan;
        private TableLayoutPanel tablePerf;
        private Button buttonTurbo;
        private Button buttonBalanced;
        private Button buttonSilent;
        private PictureBox picturePerf;
        private Label labelPerf;
        private CheckBox checkGPU;
        private Button buttonQuit;
        private PictureBox pictureScreen;
        private Label labelSreen;
        private TableLayoutPanel tableScreen;
        private Button button120Hz;
        private Button button60Hz;
        private CheckBox checkScreen;
        private CheckBox checkBoost;
    }
}