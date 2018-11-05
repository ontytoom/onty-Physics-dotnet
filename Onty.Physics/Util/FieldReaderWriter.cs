using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Serialization;

using Onty.Physics.Domain;


namespace Onty.Physics.Util
{
    public static class FieldReaderWriter
    {

        // functions
   //     public static string ConvertFieldToXml( this Field f, string fileName )
   //     {
   //         XmlDocument doc = new XmlDocument();
   //         XmlNode docNode = doc.CreateXmlDeclaration( "1.0", "UTF-8", null );
   //         doc.AppendChild( docNode );

   //         XmlNode root = doc.CreateElement( "antsConfig" );
   //         doc.AppendChild( root );


   //         // output field

   //         XmlNode field = doc.CreateElement( "field" );
			//root.AppendChild( field );

   //         XmlNode fieldTime = doc.CreateElement( "time" );
   //         field.AppendChild( fieldTime );
   //         fieldTime.AppendChild( doc.CreateTextNode( f.time.ToString() ) );

   //         XmlNode fieldSize = doc.CreateElement( "size" );
			//field.AppendChild( fieldSize );

   //         XmlAttribute fieldSizeX = doc.CreateAttribute( "width" );
   //         fieldSizeX.Value = f.size.Width.ToString();
   //         fieldSize.Attributes.Append( fieldSizeX );

   //         XmlAttribute fieldSizeY = doc.CreateAttribute( "height" );
   //         fieldSizeY.Value = f.size.Height.ToString();
   //         fieldSize.Attributes.Append( fieldSizeY );


   //         // output all yacheyki

   //         XmlNode yacheyki = doc.CreateElement( "yacheyki" );

			//XmlAttribute yacheykiCount = doc.CreateAttribute( "count" );
			//yacheykiCount.Value = f.yacheyki.Count.ToString();
			//yacheyki.Attributes.Append( yacheykiCount );

			//root.AppendChild( yacheyki );

			//for ( int yId = 0; yId < f.yacheyki.Count; yId++ )
			//{
			//	Yacheyka y = f.yacheyki[yId];

			//	// <Yacheyka id="1">
			//	XmlNode yach = doc.CreateElement( "yacheyka" );
			//	yacheyki.AppendChild( yach );

			//	XmlAttribute yachId = doc.CreateAttribute( "id" );
			//	yachId.Value = y.id.ToString();
			//	yach.Attributes.Append( yachId );

			//	// <location x=10 y=20 />
			//	XmlNode yachLoc = doc.CreateElement( "location" );
			//	yach.AppendChild( yachLoc );

			//	XmlAttribute yachLocX = doc.CreateAttribute( "x" );
			//	yachLocX.Value = y.location.x.ToString();
			//	yachLoc.Attributes.Append( yachLocX );

			//	XmlAttribute yachLocY = doc.CreateAttribute( "y" );
			//	yachLocY.Value = y.location.y.ToString();
			//	yachLoc.Attributes.Append( yachLocY );

			//	// <size>10</size>
			//	XmlNode yachSize = doc.CreateElement( "size" );
			//	yach.AppendChild( yachSize );

			//	XmlText yachSizeText = doc.CreateTextNode( y.size.ToString() );
			//	yachSize.AppendChild( yachSizeText );

			//	// <myant>1</myant>
			//	if ( y.myAnt != null )
			//	{
			//		XmlNode yachMyant = doc.CreateElement( "myant" );
			//		yach.AppendChild( yachMyant );

			//		XmlText yachMyantText = doc.CreateTextNode( y.myAnt.id.ToString() );
			//		yachMyant.AppendChild( yachMyantText );
			//	}
			//}


   //         // output all ants

			//XmlNode ants = doc.CreateElement( "ants" );

			//XmlAttribute antsCount = doc.CreateAttribute( "count" );
			//antsCount.Value = f.things.Count.ToString();
			//ants.Attributes.Append( yacheykiCount );

			//root.AppendChild( ants );

			//for ( int tId = 0; tId < f.things.Count; tId++ )
			//{
			//	Thing a = f.things[tId];

			//	// <ant id="1">
			//	XmlNode ant = doc.CreateElement( "ant" );
			//	ants.AppendChild( ant );

			//	XmlAttribute antId = doc.CreateAttribute( "id" );
			//	antId.Value = a.id.ToString();
			//	ant.Attributes.Append( antId );

			//	// <location x=10 y=20 />
			//	XmlNode antLoc = doc.CreateElement( "location" );
			//	ant.AppendChild( antLoc );

			//	XmlAttribute antLocX = doc.CreateAttribute( "x" );
			//	antLocX.Value = a.location.x.ToString();
			//	antLoc.Attributes.Append( antLocX );

			//	XmlAttribute antLocY = doc.CreateAttribute( "y" );
			//	antLocY.Value = a.location.y.ToString();
			//	antLoc.Attributes.Append( antLocY );

			//	// <velocity i=10 j=20 />
			//	XmlNode antVel = doc.CreateElement( "velocity" );
			//	ant.AppendChild( antVel );

			//	XmlAttribute antVelI = doc.CreateAttribute( "i" );
			//	antVelI.Value = a.velocity.i.ToString();
			//	antVel.Attributes.Append( antVelI );

			//	XmlAttribute antVelJ = doc.CreateAttribute( "j" );
			//	antVelJ.Value = a.velocity.j.ToString();
			//	antVel.Attributes.Append( antVelJ );

			//	// <size>10</size>
			//	XmlNode antSize = doc.CreateElement( "size" );
			//	ant.AppendChild( antSize );

			//	XmlText antSizeText = doc.CreateTextNode( a.size.ToString() );
			//	antSize.AppendChild( antSizeText );

			//	// <color red="255" green="255" blue="255" />
			//	XmlNode antColor = doc.CreateElement( "color" );
			//	ant.AppendChild( antColor );

			//	XmlAttribute antColorR = doc.CreateAttribute( "red" );
			//	antColorR.Value = a.color.R.ToString();
			//	antColor.Attributes.Append( antColorR );

			//	XmlAttribute antColorG = doc.CreateAttribute( "green" );
			//	antColorG.Value = a.color.G.ToString();
			//	antColor.Attributes.Append( antColorG );

			//	XmlAttribute antColorB = doc.CreateAttribute( "blue" );
			//	antColorB.Value = a.color.B.ToString();
			//	antColor.Attributes.Append( antColorB );

			//	// <myyacheyka>1</myyacheyka>
			//	if ( a.myYach != null )
			//	{
			//		XmlNode antMyyach = doc.CreateElement( "myyacheyka" );
			//		ant.AppendChild( antMyyach );

			//		XmlText antMyyachText = doc.CreateTextNode( a.myYach.id.ToString() );
			//		antMyyach.AppendChild( antMyyachText );
			//	}
			//}


			//// make StringBuilder

   //         StringBuilder sb = new StringBuilder();

			//XmlWriterSettings xmlWS = new XmlWriterSettings();
			//xmlWS.NewLineHandling = NewLineHandling.Entitize;

   //         XmlWriter xmlWriter = XmlWriter.Create( sb, xmlWS );
			//doc.Save( xmlWriter );
			//doc.Save( fileName );

   //         return sb.ToString();

   //     }


		public static void ConvertFieldToXml2( Field f, string fileName )
		{
			XmlSerializer serializer = new XmlSerializer( typeof( Domain.Field ) );

			TextWriter tw = new StreamWriter( fileName );

			XmlSerializerNamespaces xns = new XmlSerializerNamespaces();
			xns.Add( string.Empty, string.Empty );

			serializer.Serialize( tw, f, xns );

			tw.Close();
		}


		//public static Field ConvertXmlToField( string fileName )
		//{
		//	XmlDocument xml = new XmlDocument();
		//	xml.Load( fileName );

		//	XPathNavigator xPathNav = xml.CreateNavigator();


		//	// field

		//	XPathNavigator xPathNav2 = xPathNav.SelectSingleNode( "/antsConfig/field" );

		//	int time = xPathNav2.SelectSingleNode( "time" ).ValueAsInt;

		//	XPathNavigator nav3 = xPathNav2.SelectSingleNode( "size" );
		//	int width  = Int32.Parse( nav3.GetAttribute( "width" , "" ) );
		//	int height = Int32.Parse( nav3.GetAttribute( "height", "" ) );

		//	// make the field
		//	Field f = new Field( new System.Drawing.Size( width, height ), 0, 0 );



		//	// yacheyki

		//	Dictionary<int, int> mapAntsToYach = new Dictionary<int, int>();



		//	xPathNav2 = xPathNav.SelectSingleNode( "/antsConfig/yacheyki" );

		//	bool keepReading = xPathNav2.MoveToFirstChild();

		//	while ( keepReading )
		//	{
		//		// id
		//		int id = Int32.Parse( xPathNav2.GetAttribute( "id", "" ) );

		//		// location
		//		nav3 = xPathNav2.SelectSingleNode( "location" );
		//		double x = double.Parse( nav3.GetAttribute( "x", "" ) );
		//		double y = double.Parse( nav3.GetAttribute( "y", "" ) );

		//		// size
		//		double size = xPathNav2.SelectSingleNode( "size" ).ValueAsDouble;

		//		// myAnt, if present
		//		nav3 = xPathNav2.SelectSingleNode( "myant" );
		//		int myAnt = -1;

		//		if ( nav3 != null )
		//		{
		//			myAnt = nav3.ValueAsInt;
		//			mapAntsToYach.Add( myAnt, id );
		//		}

		//		// make the yach
		//		Yacheyka yach = new Yacheyka( f );
		//		yach.location = new Location( x, y );
		//		yach.size = size;
		//		yach.id = id;

		//		f.yacheyki.Add( yach );

		//		// next node
		//		keepReading = xPathNav2.MoveToNext();
		//	}


		//	// ants

		//	xPathNav2 = xPathNav.SelectSingleNode( "/antsConfig/ants" );

		//	keepReading = xPathNav2.MoveToFirstChild();

		//	while ( keepReading )
		//	{
		//		// id
		//		int id = Int32.Parse( xPathNav2.GetAttribute( "id", "" ) );

		//		// location
		//		nav3 = xPathNav2.SelectSingleNode( "location" );
		//		string x = nav3.GetAttribute( "x", "" );
		//		string y = nav3.GetAttribute( "y", "" );

		//		// velocity
		//		nav3 = xPathNav2.SelectSingleNode( "velocity" );
		//		string i = nav3.GetAttribute( "i", "" );
		//		string j = nav3.GetAttribute( "j", "" );

		//		// size
		//		double size = xPathNav2.SelectSingleNode( "size" ).ValueAsDouble;

		//		// color
		//		nav3 = xPathNav2.SelectSingleNode( "color" );
		//		int r = Int32.Parse( nav3.GetAttribute( "red", "" ) );
		//		int g = Int32.Parse( nav3.GetAttribute( "green", "" ) );
		//		int b = Int32.Parse( nav3.GetAttribute( "blue", "" ) );

		//		// myyach, if present
		//		nav3 = xPathNav2.SelectSingleNode( "myyacheyka" );
		//		int myYach = -1;

		//		if ( nav3 != null )
		//		{
		//			myYach = nav3.ValueAsInt;
		//			if ( mapAntsToYach[id] != myYach )
		//				throw new AntsException( "mismatch" );
		//		}


		//		// make the ant
		//		Location loc = new Location( double.Parse( x ), double.Parse( y ) );
		//		Velocity vel = new Velocity( double.Parse( i ), double.Parse( j ) );

		//		Thing ant = new Thing( f, loc, vel, size );
		//		ant.color = System.Drawing.Color.FromArgb( r, g, b );

		//		ant.id = id;

		//		f.ants.Add( ant );

		//		// next node
		//		keepReading = xPathNav2.MoveToNext();
		//	}


		//	// now we will look over mapping and see which ant is in which yach

		//	foreach( KeyValuePair<int,int> pair in mapAntsToYach )
		//	{
		//		int idAnt  = pair.Key;
		//		int idYach = pair.Value;

		//		// make sure location is identical
		//		Thing a      = f.GetThing( idAnt );
		//		Yacheyka y = f.GetYacheyka( idYach );

		//		if ( a.location.x != y.location.x || a.location.y != y.location.y )
		//			throw new AntsException( "Location mismatch" );

		//		if ( a.velocity.i != 0 || a.velocity.j != 0 )
		//			throw new AntsException( "Velocity not 0" );

		//		// ok
		//		a.myYach = y;
		//		y.myAnt = a;
		//	}


		//	return f;
		//}



	}//class FieldReaderWriter

}//ns

