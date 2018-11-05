namespace Onty.Physics.UI
{
	partial class FormConfig
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
			if (disposing && (components != null))
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
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonCxl = new System.Windows.Forms.Button();
			this.textNrThings = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textSizeMin = new System.Windows.Forms.TextBox();
			this.textSizeMax = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textViewportTop = new System.Windows.Forms.TextBox();
			this.textViewportBottom = new System.Windows.Forms.TextBox();
			this.labelFillFactor = new System.Windows.Forms.Label();
			this.linkVerify = new System.Windows.Forms.LinkLabel();
			this.checkLogStdout = new System.Windows.Forms.CheckBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textKGravity = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textTimeIncrement = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.textTimeSleepIter = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.textViewportLeft = new System.Windows.Forms.TextBox();
			this.textViewportRight = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.linkViewportAuto = new System.Windows.Forms.LinkLabel();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.textViewportZoom = new System.Windows.Forms.TextBox();
			this.textViewportShift = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// buttonSave
			// 
			this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonSave.Location = new System.Drawing.Point(12, 580);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(75, 23);
			this.buttonSave.TabIndex = 101;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// buttonCxl
			// 
			this.buttonCxl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCxl.Location = new System.Drawing.Point(287, 580);
			this.buttonCxl.Name = "buttonCxl";
			this.buttonCxl.Size = new System.Drawing.Size(75, 23);
			this.buttonCxl.TabIndex = 102;
			this.buttonCxl.Text = "Cancel";
			this.buttonCxl.UseVisualStyleBackColor = true;
			this.buttonCxl.Click += new System.EventHandler(this.buttonCxl_Click);
			// 
			// textNrThings
			// 
			this.textNrThings.Location = new System.Drawing.Point(127, 268);
			this.textNrThings.Name = "textNrThings";
			this.textNrThings.Size = new System.Drawing.Size(61, 20);
			this.textNrThings.TabIndex = 52;
			this.textNrThings.Enter += new System.EventHandler(this.textALL_Enter);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(19, 271);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 13);
			this.label1.TabIndex = 51;
			this.label1.Text = "Number of Things";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(19, 308);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 13);
			this.label3.TabIndex = 61;
			this.label3.Text = "Minimum Size";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(19, 332);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(74, 13);
			this.label4.TabIndex = 63;
			this.label4.Text = "Maximum Size";
			// 
			// textSizeMin
			// 
			this.textSizeMin.Location = new System.Drawing.Point(127, 305);
			this.textSizeMin.Name = "textSizeMin";
			this.textSizeMin.Size = new System.Drawing.Size(61, 20);
			this.textSizeMin.TabIndex = 62;
			this.textSizeMin.Enter += new System.EventHandler(this.textALL_Enter);
			// 
			// textSizeMax
			// 
			this.textSizeMax.Location = new System.Drawing.Point(127, 329);
			this.textSizeMax.Name = "textSizeMax";
			this.textSizeMax.Size = new System.Drawing.Size(61, 20);
			this.textSizeMax.TabIndex = 64;
			this.textSizeMax.Enter += new System.EventHandler(this.textALL_Enter);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(162, 36);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(26, 13);
			this.label5.TabIndex = 21;
			this.label5.Text = "Top";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(159, 140);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(40, 13);
			this.label6.TabIndex = 23;
			this.label6.Text = "Bottom";
			// 
			// textViewportTop
			// 
			this.textViewportTop.BackColor = System.Drawing.SystemColors.Window;
			this.textViewportTop.Location = new System.Drawing.Point(140, 52);
			this.textViewportTop.Name = "textViewportTop";
			this.textViewportTop.Size = new System.Drawing.Size(75, 20);
			this.textViewportTop.TabIndex = 22;
			this.textViewportTop.Enter += new System.EventHandler(this.textALL_Enter);
			// 
			// textViewportBottom
			// 
			this.textViewportBottom.BackColor = System.Drawing.SystemColors.Window;
			this.textViewportBottom.Location = new System.Drawing.Point(140, 117);
			this.textViewportBottom.Name = "textViewportBottom";
			this.textViewportBottom.Size = new System.Drawing.Size(75, 20);
			this.textViewportBottom.TabIndex = 24;
			this.textViewportBottom.Enter += new System.EventHandler(this.textALL_Enter);
			// 
			// labelFillFactor
			// 
			this.labelFillFactor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.labelFillFactor.Location = new System.Drawing.Point(228, 305);
			this.labelFillFactor.Name = "labelFillFactor";
			this.labelFillFactor.Size = new System.Drawing.Size(121, 78);
			this.labelFillFactor.TabIndex = 93;
			// 
			// linkVerify
			// 
			this.linkVerify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.linkVerify.AutoSize = true;
			this.linkVerify.Location = new System.Drawing.Point(93, 585);
			this.linkVerify.Name = "linkVerify";
			this.linkVerify.Size = new System.Drawing.Size(32, 13);
			this.linkVerify.TabIndex = 103;
			this.linkVerify.TabStop = true;
			this.linkVerify.Text = "verify";
			this.linkVerify.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkVerify_LinkClicked);
			// 
			// checkLogStdout
			// 
			this.checkLogStdout.AutoSize = true;
			this.checkLogStdout.Location = new System.Drawing.Point(230, 271);
			this.checkLogStdout.Name = "checkLogStdout";
			this.checkLogStdout.Size = new System.Drawing.Size(88, 17);
			this.checkLogStdout.TabIndex = 92;
			this.checkLogStdout.Text = "Log to stdout";
			this.checkLogStdout.UseVisualStyleBackColor = true;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(227, 242);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(61, 20);
			this.label9.TabIndex = 91;
			this.label9.Text = "Debug:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(19, 370);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(92, 13);
			this.label2.TabIndex = 71;
			this.label2.Text = "Gravity coefficient";
			// 
			// textKGravity
			// 
			this.textKGravity.Location = new System.Drawing.Point(127, 367);
			this.textKGravity.Name = "textKGravity";
			this.textKGravity.Size = new System.Drawing.Size(61, 20);
			this.textKGravity.TabIndex = 73;
			this.textKGravity.Enter += new System.EventHandler(this.textALL_Enter);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(19, 405);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(80, 13);
			this.label7.TabIndex = 81;
			this.label7.Text = "Time Increment";
			// 
			// textTimeIncrement
			// 
			this.textTimeIncrement.Location = new System.Drawing.Point(128, 402);
			this.textTimeIncrement.Name = "textTimeIncrement";
			this.textTimeIncrement.Size = new System.Drawing.Size(61, 20);
			this.textTimeIncrement.TabIndex = 83;
			this.textTimeIncrement.Enter += new System.EventHandler(this.textALL_Enter);
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(19, 431);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(103, 29);
			this.label8.TabIndex = 85;
			this.label8.Text = "Sleep Between Iterations";
			// 
			// textTimeSleepIter
			// 
			this.textTimeSleepIter.Location = new System.Drawing.Point(128, 428);
			this.textTimeSleepIter.Name = "textTimeSleepIter";
			this.textTimeSleepIter.Size = new System.Drawing.Size(61, 20);
			this.textTimeSleepIter.TabIndex = 87;
			this.textTimeSleepIter.Enter += new System.EventHandler(this.textALL_Enter);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(12, 13);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(75, 20);
			this.label10.TabIndex = 12;
			this.label10.Text = "Viewport:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(70, 74);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(25, 13);
			this.label11.TabIndex = 25;
			this.label11.Text = "Left";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(256, 74);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(32, 13);
			this.label12.TabIndex = 27;
			this.label12.Text = "Right";
			// 
			// textViewportLeft
			// 
			this.textViewportLeft.BackColor = System.Drawing.SystemColors.Window;
			this.textViewportLeft.Location = new System.Drawing.Point(40, 89);
			this.textViewportLeft.Name = "textViewportLeft";
			this.textViewportLeft.Size = new System.Drawing.Size(85, 20);
			this.textViewportLeft.TabIndex = 26;
			this.textViewportLeft.Enter += new System.EventHandler(this.textALL_Enter);
			// 
			// textViewportRight
			// 
			this.textViewportRight.BackColor = System.Drawing.SystemColors.Window;
			this.textViewportRight.Location = new System.Drawing.Point(235, 90);
			this.textViewportRight.Name = "textViewportRight";
			this.textViewportRight.Size = new System.Drawing.Size(77, 20);
			this.textViewportRight.TabIndex = 28;
			this.textViewportRight.Enter += new System.EventHandler(this.textALL_Enter);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(18, 239);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(53, 20);
			this.label13.TabIndex = 31;
			this.label13.Text = "Other:";
			// 
			// linkViewportAuto
			// 
			this.linkViewportAuto.AutoSize = true;
			this.linkViewportAuto.Location = new System.Drawing.Point(150, 89);
			this.linkViewportAuto.Name = "linkViewportAuto";
			this.linkViewportAuto.Size = new System.Drawing.Size(54, 13);
			this.linkViewportAuto.TabIndex = 104;
			this.linkViewportAuto.TabStop = true;
			this.linkViewportAuto.Text = "Automatic";
			this.linkViewportAuto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkViewportAuto_LinkClicked);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(19, 181);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(89, 13);
			this.label14.TabIndex = 25;
			this.label14.Text = "Viewport Zoom %";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(19, 205);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(83, 13);
			this.label15.TabIndex = 27;
			this.label15.Text = "Viewport Shift %";
			// 
			// textViewportZoom
			// 
			this.textViewportZoom.Location = new System.Drawing.Point(127, 178);
			this.textViewportZoom.Name = "textViewportZoom";
			this.textViewportZoom.Size = new System.Drawing.Size(61, 20);
			this.textViewportZoom.TabIndex = 26;
			this.textViewportZoom.Enter += new System.EventHandler(this.textALL_Enter);
			// 
			// textViewportShift
			// 
			this.textViewportShift.Location = new System.Drawing.Point(127, 202);
			this.textViewportShift.Name = "textViewportShift";
			this.textViewportShift.Size = new System.Drawing.Size(61, 20);
			this.textViewportShift.TabIndex = 28;
			this.textViewportShift.Enter += new System.EventHandler(this.textALL_Enter);
			// 
			// FormConfig
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(374, 615);
			this.Controls.Add(this.linkViewportAuto);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.linkVerify);
			this.Controls.Add(this.labelFillFactor);
			this.Controls.Add(this.textTimeSleepIter);
			this.Controls.Add(this.textTimeIncrement);
			this.Controls.Add(this.textKGravity);
			this.Controls.Add(this.textViewportShift);
			this.Controls.Add(this.textSizeMax);
			this.Controls.Add(this.textViewportRight);
			this.Controls.Add(this.textViewportBottom);
			this.Controls.Add(this.textViewportZoom);
			this.Controls.Add(this.textSizeMin);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.textViewportLeft);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textViewportTop);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textNrThings);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonCxl);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.checkLogStdout);
			this.MinimumSize = new System.Drawing.Size(384, 468);
			this.Name = "FormConfig";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Onty.Physics Config";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button buttonCxl;
		private System.Windows.Forms.TextBox textNrThings;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textSizeMin;
		private System.Windows.Forms.TextBox textSizeMax;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textViewportTop;
		private System.Windows.Forms.TextBox textViewportBottom;
		private System.Windows.Forms.Label labelFillFactor;
		private System.Windows.Forms.LinkLabel linkVerify;
		private System.Windows.Forms.CheckBox checkLogStdout;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textKGravity;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textTimeIncrement;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textTimeSleepIter;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox textViewportLeft;
		private System.Windows.Forms.TextBox textViewportRight;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.LinkLabel linkViewportAuto;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox textViewportZoom;
		private System.Windows.Forms.TextBox textViewportShift;
	}
}