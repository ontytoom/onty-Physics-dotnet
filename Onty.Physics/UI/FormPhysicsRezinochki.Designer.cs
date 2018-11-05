namespace Onty.Physics.UI
{
	partial class FormPhysicsRezinochki
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && (components != null) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPhysicsRezinochki));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.Init = new System.Windows.Forms.Button();
			this.textDebug = new System.Windows.Forms.TextBox();
			this.linkDebug2 = new System.Windows.Forms.LinkLabel();
			this.buttonIncrTime = new System.Windows.Forms.Button();
			this.buttonRun = new System.Windows.Forms.Button();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.buttonStop = new System.Windows.Forms.Button();
			this.labelStatus = new System.Windows.Forms.Label();
			this.linkDebugClear = new System.Windows.Forms.LinkLabel();
			this.linkDebug = new System.Windows.Forms.LinkLabel();
			this.menuMain = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_open = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem_saveAs = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_SaveAs2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_ZoomIn = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_ZoomOut = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_TestRectangle = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.about2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.labelStatus2 = new System.Windows.Forms.Label();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.buttonZoomIn = new System.Windows.Forms.Button();
			this.buttonZoomOut = new System.Windows.Forms.Button();
			this.linkViewportDown = new System.Windows.Forms.LinkLabel();
			this.linkViewportUp = new System.Windows.Forms.LinkLabel();
			this.linkViewportLeft = new System.Windows.Forms.LinkLabel();
			this.linkViewportRight = new System.Windows.Forms.LinkLabel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.menuMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.pictureBox1.Location = new System.Drawing.Point(13, 60);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(307, 261);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.pictureBox1_PreviewKeyDown);
			// 
			// Init
			// 
			this.Init.Location = new System.Drawing.Point(15, 31);
			this.Init.Name = "Init";
			this.Init.Size = new System.Drawing.Size(51, 23);
			this.Init.TabIndex = 31;
			this.Init.Text = "init";
			this.Init.UseVisualStyleBackColor = true;
			this.Init.Click += new System.EventHandler(this.buttonInit_Click);
			// 
			// textDebug
			// 
			this.textDebug.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textDebug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.textDebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textDebug.Location = new System.Drawing.Point(399, 60);
			this.textDebug.Multiline = true;
			this.textDebug.Name = "textDebug";
			this.textDebug.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textDebug.Size = new System.Drawing.Size(206, 329);
			this.textDebug.TabIndex = 61;
			// 
			// linkDebug2
			// 
			this.linkDebug2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.linkDebug2.AutoSize = true;
			this.linkDebug2.Location = new System.Drawing.Point(562, 43);
			this.linkDebug2.Name = "linkDebug2";
			this.linkDebug2.Size = new System.Drawing.Size(43, 13);
			this.linkDebug2.TabIndex = 52;
			this.linkDebug2.TabStop = true;
			this.linkDebug2.Text = "debug2";
			this.linkDebug2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDebug2_LinkClicked);
			// 
			// buttonIncrTime
			// 
			this.buttonIncrTime.Location = new System.Drawing.Point(72, 31);
			this.buttonIncrTime.Name = "buttonIncrTime";
			this.buttonIncrTime.Size = new System.Drawing.Size(65, 23);
			this.buttonIncrTime.TabIndex = 32;
			this.buttonIncrTime.Text = "one step";
			this.buttonIncrTime.UseVisualStyleBackColor = true;
			this.buttonIncrTime.Click += new System.EventHandler(this.buttonIncrTime_Click);
			// 
			// buttonRun
			// 
			this.buttonRun.Location = new System.Drawing.Point(143, 31);
			this.buttonRun.Name = "buttonRun";
			this.buttonRun.Size = new System.Drawing.Size(44, 23);
			this.buttonRun.TabIndex = 34;
			this.buttonRun.Text = "run";
			this.buttonRun.UseVisualStyleBackColor = true;
			this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
			// 
			// backgroundWorker1
			// 
			this.backgroundWorker1.WorkerSupportsCancellation = true;
			this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
			this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
			// 
			// buttonStop
			// 
			this.buttonStop.Location = new System.Drawing.Point(193, 31);
			this.buttonStop.Name = "buttonStop";
			this.buttonStop.Size = new System.Drawing.Size(49, 23);
			this.buttonStop.TabIndex = 35;
			this.buttonStop.Text = "stop";
			this.buttonStop.UseVisualStyleBackColor = true;
			this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
			// 
			// labelStatus
			// 
			this.labelStatus.Location = new System.Drawing.Point(248, 36);
			this.labelStatus.Name = "labelStatus";
			this.labelStatus.Size = new System.Drawing.Size(272, 15);
			this.labelStatus.TabIndex = 5;
			this.labelStatus.Text = "[status]";
			this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// linkDebugClear
			// 
			this.linkDebugClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.linkDebugClear.AutoSize = true;
			this.linkDebugClear.Location = new System.Drawing.Point(526, 36);
			this.linkDebugClear.Name = "linkDebugClear";
			this.linkDebugClear.Size = new System.Drawing.Size(30, 13);
			this.linkDebugClear.TabIndex = 51;
			this.linkDebugClear.TabStop = true;
			this.linkDebugClear.Text = "clear";
			this.linkDebugClear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDebugClear_LinkClicked);
			// 
			// linkDebug
			// 
			this.linkDebug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.linkDebug.AutoSize = true;
			this.linkDebug.Location = new System.Drawing.Point(562, 28);
			this.linkDebug.Name = "linkDebug";
			this.linkDebug.Size = new System.Drawing.Size(37, 13);
			this.linkDebug.TabIndex = 52;
			this.linkDebug.TabStop = true;
			this.linkDebug.Text = "debug";
			this.linkDebug.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDebug_LinkClicked);
			// 
			// menuMain
			// 
			this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuMain.Location = new System.Drawing.Point(0, 0);
			this.menuMain.Name = "menuMain";
			this.menuMain.Size = new System.Drawing.Size(617, 24);
			this.menuMain.TabIndex = 62;
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_open,
            this.ToolStripMenuItem_saveAs,
            this.toolStripMenuItem_SaveAs2,
            this.toolStripSeparator1,
            this.quitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// toolStripMenuItem_open
			// 
			this.toolStripMenuItem_open.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem_open.Image")));
			this.toolStripMenuItem_open.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripMenuItem_open.Name = "toolStripMenuItem_open";
			this.toolStripMenuItem_open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.toolStripMenuItem_open.Size = new System.Drawing.Size(140, 22);
			this.toolStripMenuItem_open.Text = "&Open";
			this.toolStripMenuItem_open.Visible = false;
			this.toolStripMenuItem_open.Click += new System.EventHandler(this.toolStripMenuItem_Open_Click);
			// 
			// ToolStripMenuItem_saveAs
			// 
			this.ToolStripMenuItem_saveAs.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItem_saveAs.Image")));
			this.ToolStripMenuItem_saveAs.Name = "ToolStripMenuItem_saveAs";
			this.ToolStripMenuItem_saveAs.Size = new System.Drawing.Size(140, 22);
			this.ToolStripMenuItem_saveAs.Text = "Save &As";
			this.ToolStripMenuItem_saveAs.Visible = false;
			this.ToolStripMenuItem_saveAs.Click += new System.EventHandler(this.toolStripMenuItem_SaveAs_Click);
			// 
			// toolStripMenuItem_SaveAs2
			// 
			this.toolStripMenuItem_SaveAs2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem_SaveAs2.Image")));
			this.toolStripMenuItem_SaveAs2.Name = "toolStripMenuItem_SaveAs2";
			this.toolStripMenuItem_SaveAs2.Size = new System.Drawing.Size(140, 22);
			this.toolStripMenuItem_SaveAs2.Text = "Save &As 2";
			this.toolStripMenuItem_SaveAs2.Visible = false;
			this.toolStripMenuItem_SaveAs2.Click += new System.EventHandler(this.toolStripMenuItem_SaveAs2_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(137, 6);
			// 
			// quitToolStripMenuItem
			// 
			this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
			this.quitToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
			this.quitToolStripMenuItem.Text = "&Quit";
			this.quitToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem_Quit_Click);
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_ZoomIn,
            this.toolStripMenuItem_ZoomOut});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
			this.viewToolStripMenuItem.Text = "View";
			// 
			// toolStripMenuItem_ZoomIn
			// 
			this.toolStripMenuItem_ZoomIn.Name = "toolStripMenuItem_ZoomIn";
			this.toolStripMenuItem_ZoomIn.Size = new System.Drawing.Size(121, 22);
			this.toolStripMenuItem_ZoomIn.Text = "Zoom In";
			this.toolStripMenuItem_ZoomIn.Click += new System.EventHandler(this.toolStripMenuItem_ZoomIn_Click);
			// 
			// toolStripMenuItem_ZoomOut
			// 
			this.toolStripMenuItem_ZoomOut.Name = "toolStripMenuItem_ZoomOut";
			this.toolStripMenuItem_ZoomOut.Size = new System.Drawing.Size(121, 22);
			this.toolStripMenuItem_ZoomOut.Text = "Zoom Out";
			this.toolStripMenuItem_ZoomOut.Click += new System.EventHandler(this.toolStripMenuItem_ZoomOut_Click);
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configToolStripMenuItem,
            this.toolStripMenuItem_TestRectangle});
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.toolsToolStripMenuItem.Text = "Tools";
			// 
			// configToolStripMenuItem
			// 
			this.configToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("configToolStripMenuItem.Image")));
			this.configToolStripMenuItem.Name = "configToolStripMenuItem";
			this.configToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.configToolStripMenuItem.Text = "Config";
			this.configToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem_Config_Click);
			// 
			// toolStripMenuItem_TestRectangle
			// 
			this.toolStripMenuItem_TestRectangle.Name = "toolStripMenuItem_TestRectangle";
			this.toolStripMenuItem_TestRectangle.Size = new System.Drawing.Size(152, 22);
			this.toolStripMenuItem_TestRectangle.Text = "Test Rectangle";
			this.toolStripMenuItem_TestRectangle.Click += new System.EventHandler(this.toolStripMenuItem_TestRectangle_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.about2ToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// about2ToolStripMenuItem
			// 
			this.about2ToolStripMenuItem.Name = "about2ToolStripMenuItem";
			this.about2ToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
			this.about2ToolStripMenuItem.Text = "About...";
			this.about2ToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem_About2_Click);
			// 
			// labelStatus2
			// 
			this.labelStatus2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelStatus2.Location = new System.Drawing.Point(21, 328);
			this.labelStatus2.Name = "labelStatus2";
			this.labelStatus2.Size = new System.Drawing.Size(339, 15);
			this.labelStatus2.TabIndex = 63;
			this.labelStatus2.Text = "[status 2]";
			this.labelStatus2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// trackBar1
			// 
			this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.trackBar1.Location = new System.Drawing.Point(13, 346);
			this.trackBar1.Maximum = 0;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(380, 42);
			this.trackBar1.TabIndex = 64;
			// 
			// buttonZoomIn
			// 
			this.buttonZoomIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonZoomIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonZoomIn.Location = new System.Drawing.Point(344, 60);
			this.buttonZoomIn.Name = "buttonZoomIn";
			this.buttonZoomIn.Size = new System.Drawing.Size(25, 28);
			this.buttonZoomIn.TabIndex = 65;
			this.buttonZoomIn.Text = "&+";
			this.buttonZoomIn.UseVisualStyleBackColor = true;
			this.buttonZoomIn.Click += new System.EventHandler(this.buttonZoomIn_Click);
			// 
			// buttonZoomOut
			// 
			this.buttonZoomOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonZoomOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonZoomOut.Location = new System.Drawing.Point(344, 94);
			this.buttonZoomOut.Name = "buttonZoomOut";
			this.buttonZoomOut.Size = new System.Drawing.Size(25, 25);
			this.buttonZoomOut.TabIndex = 65;
			this.buttonZoomOut.Text = "&-";
			this.buttonZoomOut.UseVisualStyleBackColor = true;
			this.buttonZoomOut.Click += new System.EventHandler(this.buttonZoomOut_Click);
			// 
			// linkViewportDown
			// 
			this.linkViewportDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.linkViewportDown.AutoSize = true;
			this.linkViewportDown.Location = new System.Drawing.Point(340, 189);
			this.linkViewportDown.Name = "linkViewportDown";
			this.linkViewportDown.Size = new System.Drawing.Size(35, 13);
			this.linkViewportDown.TabIndex = 66;
			this.linkViewportDown.TabStop = true;
			this.linkViewportDown.Text = "Down";
			this.linkViewportDown.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkViewportDown_LinkClicked);
			// 
			// linkViewportUp
			// 
			this.linkViewportUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.linkViewportUp.AutoSize = true;
			this.linkViewportUp.Location = new System.Drawing.Point(348, 139);
			this.linkViewportUp.Name = "linkViewportUp";
			this.linkViewportUp.Size = new System.Drawing.Size(21, 13);
			this.linkViewportUp.TabIndex = 66;
			this.linkViewportUp.TabStop = true;
			this.linkViewportUp.Text = "Up";
			this.linkViewportUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkViewportUp_LinkClicked);
			// 
			// linkViewportLeft
			// 
			this.linkViewportLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.linkViewportLeft.AutoSize = true;
			this.linkViewportLeft.Location = new System.Drawing.Point(326, 164);
			this.linkViewportLeft.Name = "linkViewportLeft";
			this.linkViewportLeft.Size = new System.Drawing.Size(25, 13);
			this.linkViewportLeft.TabIndex = 66;
			this.linkViewportLeft.TabStop = true;
			this.linkViewportLeft.Text = "Left";
			this.linkViewportLeft.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkViewportLeft_LinkClicked);
			// 
			// linkViewportRight
			// 
			this.linkViewportRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.linkViewportRight.AutoSize = true;
			this.linkViewportRight.Location = new System.Drawing.Point(365, 164);
			this.linkViewportRight.Name = "linkViewportRight";
			this.linkViewportRight.Size = new System.Drawing.Size(32, 13);
			this.linkViewportRight.TabIndex = 66;
			this.linkViewportRight.TabStop = true;
			this.linkViewportRight.Text = "Right";
			this.linkViewportRight.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkViewportRight_LinkClicked);
			// 
			// FormPhysicsRezinochki
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(617, 401);
			this.Controls.Add(this.linkViewportRight);
			this.Controls.Add(this.linkViewportLeft);
			this.Controls.Add(this.linkViewportUp);
			this.Controls.Add(this.linkViewportDown);
			this.Controls.Add(this.buttonZoomOut);
			this.Controls.Add(this.buttonZoomIn);
			this.Controls.Add(this.trackBar1);
			this.Controls.Add(this.labelStatus2);
			this.Controls.Add(this.labelStatus);
			this.Controls.Add(this.linkDebugClear);
			this.Controls.Add(this.linkDebug);
			this.Controls.Add(this.linkDebug2);
			this.Controls.Add(this.textDebug);
			this.Controls.Add(this.buttonStop);
			this.Controls.Add(this.buttonRun);
			this.Controls.Add(this.buttonIncrTime);
			this.Controls.Add(this.Init);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.menuMain);
			this.MainMenuStrip = this.menuMain;
			this.Name = "FormPhysicsRezinochki";
			this.Text = "[Onty.Physics...]";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPhysics_FormClosing);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormPhysics_KeyPress);
			this.Resize += new System.EventHandler(this.FormPhysics_Resize);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.menuMain.ResumeLayout(false);
			this.menuMain.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button Init;
		private System.Windows.Forms.TextBox textDebug;
		private System.Windows.Forms.LinkLabel linkDebug2;
		private System.Windows.Forms.Button buttonIncrTime;
		private System.Windows.Forms.Button buttonRun;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Button buttonStop;
		private System.Windows.Forms.Label labelStatus;
		private System.Windows.Forms.LinkLabel linkDebugClear;
		private System.Windows.Forms.LinkLabel linkDebug;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_open;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_saveAs;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem about2ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_SaveAs2;
		private System.Windows.Forms.Label labelStatus2;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_ZoomIn;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_ZoomOut;
		private System.Windows.Forms.Button buttonZoomIn;
		private System.Windows.Forms.Button buttonZoomOut;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_TestRectangle;
		private System.Windows.Forms.LinkLabel linkViewportDown;
		private System.Windows.Forms.LinkLabel linkViewportUp;
		private System.Windows.Forms.LinkLabel linkViewportLeft;
		private System.Windows.Forms.LinkLabel linkViewportRight;
	}
}

