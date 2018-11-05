using System;
using System.Drawing;
using NUnit.Framework;
using NUnit.Framework.Constraints;

using Onty.Physics.Domain;
using Onty.Physics.Util;


namespace Onty.Physics.Tests
{
	[TestFixture]
	public class Test_Serialization
	{

		//[Test]
		//public void Test_Serialization_01()
		//{
		//	Size size = new Size( 680, 710 );
		//	int nrAnts = 14;

		//	Field f = new Field( size, nrAnts );

		//	string tempFileName = System.IO.Path.GetTempFileName();

		//	FieldReaderWriter.ConvertFieldToXml( f, tempFileName );

		//	Field f2 = FieldReaderWriter.ConvertXmlToField( tempFileName );

		//	// compare f and f2

		//	Assert.AreEqual( f.time, f2.time );
		//	Assert.AreEqual( f.size, f2.size );

		//	Assert.AreEqual( f.ants.Count, f2.ants.Count );

		//	foreach ( Ant a in f.ants )
		//	{
		//		int id = a.id;
		//		Ant a2 = f2.GetAnt( id );

		//		Assert.AreEqual( a.id, a2.id );
		//		Assert.AreEqual( a.color, a2.color );
		//		Assert.AreEqual( a.location.x, a2.location.x, 0.1 );
		//		Assert.AreEqual( a.location.y, a2.location.y, 0.1 );
		//		Assert.AreEqual( a.velocity.i, a2.velocity.i, 0.1 );
		//		Assert.AreEqual( a.velocity.j, a2.velocity.j, 0.1 );
		//		Assert.AreEqual( a.size, a2.size, 0.1 );
		//		Assert.AreEqual( f2, a2.myField );

		//		Assert.AreEqual( a.myYach==null, a2.myYach==null );

		//		if ( a.myYach!=null )
		//			Assert.AreEqual( a.myYach.id, a2.myYach.id );
		//	}

		//	Assert.AreEqual( f.yacheyki.Count, f2.yacheyki.Count );

		//	foreach ( Yacheyka y in f.yacheyki )
		//	{
		//		int id = y.id;
		//		Yacheyka y2 = f2.GetYacheyka( id );

		//		Assert.AreEqual( y.id, y2.id );
		//		Assert.AreEqual( y.location.x, y2.location.x, 0.1 );
		//		Assert.AreEqual( y.location.y, y2.location.y, 0.1 );
		//		Assert.AreEqual( y.size, y2.size, 0.1 );

		//		Assert.AreEqual( y.myAnt == null, y2.myAnt == null );

		//		if ( y.myAnt != null )
		//			Assert.AreEqual( y.myAnt.id, y2.myAnt.id );
		//	}


		//}//Test_Serialization_01()

	}//class TestSerialization

}//ns

