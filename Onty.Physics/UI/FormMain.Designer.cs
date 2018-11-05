namespace Onty.Physics.UI
{
	partial class FormMain
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
			this.linkField = new System.Windows.Forms.LinkLabel();
			this.linkField2 = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// linkField
			// 
			this.linkField.AutoSize = true;
			this.linkField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkField.Location = new System.Drawing.Point(12, 18);
			this.linkField.Name = "linkField";
			this.linkField.Size = new System.Drawing.Size(52, 24);
			this.linkField.TabIndex = 0;
			this.linkField.TabStop = true;
			this.linkField.Text = "Field";
			this.linkField.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkField_LinkClicked);
			// 
			// linkField2
			// 
			this.linkField2.AutoSize = true;
			this.linkField2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkField2.Location = new System.Drawing.Point(12, 46);
			this.linkField2.Name = "linkField2";
			this.linkField2.Size = new System.Drawing.Size(67, 24);
			this.linkField2.TabIndex = 0;
			this.linkField2.TabStop = true;
			this.linkField2.Text = "Field 2";
			this.linkField2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkField2_LinkClicked);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(183, 141);
			this.Controls.Add(this.linkField2);
			this.Controls.Add(this.linkField);
			this.Name = "FormMain";
			this.Text = "Onty.Physics Main";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.LinkLabel linkField;
		private System.Windows.Forms.LinkLabel linkField2;
	}
}