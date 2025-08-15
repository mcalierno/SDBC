namespace StudioDisplayBrightnessController
{
    partial class Form_Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.automaticTrackBar = new System.Windows.Forms.TrackBar();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automaticBrightnessValue = new System.Windows.Forms.Label();
            this.timerUpdateInterface = new System.Windows.Forms.Timer(this.components);
            this.automaticBrightnessLabel = new System.Windows.Forms.Label();
            this.enableCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerUpdateMonitorConnectionState = new System.Windows.Forms.Timer(this.components);
            this.timerProgramStart = new System.Windows.Forms.Timer(this.components);
            this.manualTrackBar = new System.Windows.Forms.TrackBar();
            this.manualBrightnessLabel = new System.Windows.Forms.Label();
            this.manualBrightnessValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.automaticTrackBar)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manualTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monitor brightness:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(644, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(24, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ambient brightness:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(644, 77);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "0";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // automaticTrackBar
            // 
            this.automaticTrackBar.LargeChange = 50;
            this.automaticTrackBar.Location = new System.Drawing.Point(30, 131);
            this.automaticTrackBar.Margin = new System.Windows.Forms.Padding(6);
            this.automaticTrackBar.Maximum = 1000;
            this.automaticTrackBar.Name = "automaticTrackBar";
            this.automaticTrackBar.Size = new System.Drawing.Size(946, 90);
            this.automaticTrackBar.SmallChange = 10;
            this.automaticTrackBar.TabIndex = 4;
            this.automaticTrackBar.TabStop = false;
            this.automaticTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.automaticTrackBar.ValueChanged += new System.EventHandler(this.automaticTrackBar_ValueChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Studio Display Brightness Controller";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(175, 118);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(174, 38);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(174, 38);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(174, 38);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // automaticBrightnessValue
            // 
            this.automaticBrightnessValue.AutoSize = true;
            this.automaticBrightnessValue.Location = new System.Drawing.Point(341, 181);
            this.automaticBrightnessValue.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.automaticBrightnessValue.Name = "automaticBrightnessValue";
            this.automaticBrightnessValue.Size = new System.Drawing.Size(24, 25);
            this.automaticBrightnessValue.TabIndex = 6;
            this.automaticBrightnessValue.Text = "0";
            // 
            // timerUpdateInterface
            // 
            this.timerUpdateInterface.Interval = 200;
            this.timerUpdateInterface.Tick += new System.EventHandler(this.timerUpdateInterface_Tick);
            // 
            // automaticBrightnessLabel
            // 
            this.automaticBrightnessLabel.AutoSize = true;
            this.automaticBrightnessLabel.Location = new System.Drawing.Point(69, 181);
            this.automaticBrightnessLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.automaticBrightnessLabel.Name = "automaticBrightnessLabel";
            this.automaticBrightnessLabel.Size = new System.Drawing.Size(270, 25);
            this.automaticBrightnessLabel.TabIndex = 10;
            this.automaticBrightnessLabel.Text = "Automatic brightness level:";
            // 
            // enableCheckBox
            // 
            this.enableCheckBox.AutoSize = true;
            this.enableCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.enableCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.enableCheckBox.Location = new System.Drawing.Point(20, 255);
            this.enableCheckBox.Margin = new System.Windows.Forms.Padding(6);
            this.enableCheckBox.Name = "enableCheckBox";
            this.enableCheckBox.Size = new System.Drawing.Size(359, 30);
            this.enableCheckBox.TabIndex = 16;
            this.enableCheckBox.Text = "Automatic brightness enabled";
            this.enableCheckBox.UseVisualStyleBackColor = true;
            this.enableCheckBox.CheckedChanged += new System.EventHandler(this.enableAutomaticBrightness_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(764, 391);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 50);
            this.button1.TabIndex = 11;
            this.button1.Text = "Hide";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(258, 46);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(6);
            this.progressBar1.MarqueeAnimationSpeed = 0;
            this.progressBar1.Maximum = 10000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(374, 6);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 12;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(258, 88);
            this.progressBar2.Margin = new System.Windows.Forms.Padding(6);
            this.progressBar2.MarqueeAnimationSpeed = 0;
            this.progressBar2.Maximum = 1000000;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(374, 6);
            this.progressBar2.Step = 1000;
            this.progressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar2.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(876, 117);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(108, 4);
            this.panel1.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::StudioDisplayBrightnessController.Properties.Resources.BMAC_Button;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(532, 391);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 50);
            this.button2.TabIndex = 15;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StudioDisplayBrightnessController.Properties.Resources.monitor_v3a_1024px;
            this.pictureBox1.Location = new System.Drawing.Point(866, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // timerUpdateMonitorConnectionState
            // 
            this.timerUpdateMonitorConnectionState.Enabled = true;
            this.timerUpdateMonitorConnectionState.Interval = 1000;
            this.timerUpdateMonitorConnectionState.Tick += new System.EventHandler(this.timerUpdateMonitorConnectionState_Tick);
            // 
            // timerProgramStart
            // 
            this.timerProgramStart.Enabled = true;
            this.timerProgramStart.Interval = 2000;
            this.timerProgramStart.Tick += new System.EventHandler(this.timerProgramStart_Tick);
            // 
            // manualTrackBar
            // 
            this.manualTrackBar.Location = new System.Drawing.Point(29, 297);
            this.manualTrackBar.Margin = new System.Windows.Forms.Padding(6);
            this.manualTrackBar.Maximum = 100;
            this.manualTrackBar.Name = "manualTrackBar";
            this.manualTrackBar.Size = new System.Drawing.Size(946, 90);
            this.manualTrackBar.TabIndex = 18;
            this.manualTrackBar.TabStop = false;
            this.manualTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.manualTrackBar.ValueChanged += new System.EventHandler(this.manualTrackBar_ValueChanged);
            // 
            // manualBrightnessLabel
            // 
            this.manualBrightnessLabel.AutoSize = true;
            this.manualBrightnessLabel.Location = new System.Drawing.Point(69, 360);
            this.manualBrightnessLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.manualBrightnessLabel.Name = "manualBrightnessLabel";
            this.manualBrightnessLabel.Size = new System.Drawing.Size(246, 25);
            this.manualBrightnessLabel.TabIndex = 19;
            this.manualBrightnessLabel.Text = "Manual brightness level:";
            // 
            // manualBrightnessValue
            // 
            this.manualBrightnessValue.AutoSize = true;
            this.manualBrightnessValue.Location = new System.Drawing.Point(336, 360);
            this.manualBrightnessValue.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.manualBrightnessValue.Name = "manualBrightnessValue";
            this.manualBrightnessValue.Size = new System.Drawing.Size(24, 25);
            this.manualBrightnessValue.TabIndex = 20;
            this.manualBrightnessValue.Text = "0";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 456);
            this.ControlBox = false;
            this.Controls.Add(this.manualBrightnessValue);
            this.Controls.Add(this.manualBrightnessLabel);
            this.Controls.Add(this.manualTrackBar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.automaticBrightnessLabel);
            this.Controls.Add(this.enableCheckBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.automaticBrightnessValue);
            this.Controls.Add(this.automaticTrackBar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Main";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Studio Display Brightness Controller";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.Form1_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.automaticTrackBar)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manualTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar automaticTrackBar;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label automaticBrightnessValue;
        private System.Windows.Forms.Timer timerUpdateInterface;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label automaticBrightnessLabel;
        private System.Windows.Forms.CheckBox enableCheckBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timerUpdateMonitorConnectionState;
        private System.Windows.Forms.Timer timerProgramStart;
        private System.Windows.Forms.TrackBar manualTrackBar;
        private System.Windows.Forms.Label manualBrightnessLabel;
        private System.Windows.Forms.Label manualBrightnessValue;
    }
}

