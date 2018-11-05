using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Onty.Physics.UI
{

	public partial class FormMain : Form
	{

		public FormMain()
		{
			InitializeComponent();
		}

		private void linkField_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
		{
			FormPhysics formPhysics = new FormPhysics();
			formPhysics.Show( this );
		}

		private void linkField2_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
		{
			FormPhysicsRezinochki formPhysicsRezinochki = new FormPhysicsRezinochki();
			formPhysicsRezinochki.Show( this );
		}

	}

}//ns

