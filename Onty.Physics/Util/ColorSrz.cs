using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Xml.Serialization;


namespace Onty.Physics.Util
{

	public class ColorSrz
	{

		[XmlAttribute]
		public int alpha;

		[XmlAttribute]
		public int red;

		[XmlAttribute]
		public int green;

		[XmlAttribute]
		public int blue;


		public ColorSrz()
		{
		}

		public ColorSrz( System.Drawing.Color sc )
		{
			this.alpha = sc.A;
			this.red   = sc.R;
			this.green = sc.G;
			this.blue  = sc.B;
		}


		//public Color getColor()
		//{
		//	return Color.FromArgb( red, green, blue );
		//}


		public static implicit operator Color( ColorSrz colorSrz )
		{
			return Color.FromArgb( colorSrz.alpha, colorSrz.red, colorSrz.green, colorSrz.blue );
		}

	}

}//ns

