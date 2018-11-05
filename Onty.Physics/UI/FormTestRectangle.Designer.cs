namespace Onty.Physics.UI
{
	partial class FormTestRectangle
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
			this.textOut = new System.Windows.Forms.TextBox();
			this.linkMul1 = new System.Windows.Forms.LinkLabel();
			this.textMul1 = new System.Windows.Forms.TextBox();
			this.textMul2 = new System.Windows.Forms.TextBox();
			this.linkMul2 = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// textOut
			// 
			this.textOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textOut.Location = new System.Drawing.Point(13, 69);
			this.textOut.Multiline = true;
			this.textOut.Name = "textOut";
			this.textOut.Size = new System.Drawing.Size(265, 190);
			this.textOut.TabIndex = 0;
			// 
			// linkMul1
			// 
			this.linkMul1.AutoSize = true;
			this.linkMul1.Location = new System.Drawing.Point(73, 12);
			this.linkMul1.Name = "linkMul1";
			this.linkMul1.Size = new System.Drawing.Size(108, 13);
			this.linkMul1.TabIndex = 1;
			this.linkMul1.TabStop = true;
			this.linkMul1.Text = "Inflate by exact value";
			this.linkMul1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkMul1_LinkClicked);
			// 
			// textMul1
			// 
			this.textMul1.Location = new System.Drawing.Point(13, 9);
			this.textMul1.Name = "textMul1";
			this.textMul1.Size = new System.Drawing.Size(54, 20);
			this.textMul1.TabIndex = 2;
			// 
			// textMul2
			// 
			this.textMul2.Location = new System.Drawing.Point(13, 35);
			this.textMul2.Name = "textMul2";
			this.textMul2.Size = new System.Drawing.Size(54, 20);
			this.textMul2.TabIndex = 2;
			// 
			// linkMul2
			// 
			this.linkMul2.AutoSize = true;
			this.linkMul2.Location = new System.Drawing.Point(73, 38);
			this.linkMul2.Name = "linkMul2";
			this.linkMul2.Size = new System.Drawing.Size(134, 13);
			this.linkMul2.TabIndex = 1;
			this.linkMul2.TabStop = true;
			this.linkMul2.Text = "Inflate proportionally to size";
			this.linkMul2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkMul2_LinkClicked);
			// 
			// FormTestRectangle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(290, 271);
			this.Controls.Add(this.textMul2);
			this.Controls.Add(this.textMul1);
			this.Controls.Add(this.linkMul2);
			this.Controls.Add(this.linkMul1);
			this.Controls.Add(this.textOut);
			this.Name = "FormTestRectangle";
			this.Text = "FormTestRectangle";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textOut;
		private System.Windows.Forms.LinkLabel linkMul1;
		private System.Windows.Forms.TextBox textMul1;
		private System.Windows.Forms.TextBox textMul2;
		private System.Windows.Forms.LinkLabel linkMul2;
	}
}