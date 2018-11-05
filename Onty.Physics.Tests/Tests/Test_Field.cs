using System;
using System.Drawing;
using NUnit.Framework;
using NUnit.Framework.Constraints;

using Onty.Physics.Domain;
using Onty.Physics.Util;


namespace Onty.Physics.Tests
{

	[TestFixture]
	public class Test_Field
	{

		[Test]
		public void Test_Field_CtorDef()
		{
			Field f = new Field();

			Assert.IsNotNull( f.things );
			Assert.AreEqual( 0, f.things.Count );

			// size is a struct, so there is an instance even when we did not assign one
			Assert.AreEqual( 100, f.Viewport.Width );
			Assert.AreEqual( 100, f.Viewport.Height );

			Assert.AreEqual( 0, f.time );

		}

		[Test]
		public void Test_Field_CtorMain()
		{
			RectangleF vp = new RectangleF( 0, 0, 680, 710 );

			GlobalConfig.viewport = vp;
			int nrThings = 14;

			Field f = new Field( nrThings );

			Assert.IsNotNull( f.things );

			Assert.AreEqual( 0, f.time );

			Assert.AreEqual( nrThings, f.things.Count );
			Assert.AreEqual( vp.Width, f.Viewport.Width );
			Assert.AreEqual( vp.Height, f.Viewport.Height );
		}

		[Test]
		public void Test_Field_GotoNewTime()
		{
			Field f = new Field( 14 );

			decimal time = f.time;

			f.GotoNewTime();

			Assert.IsTrue( f.time > time );
		}

		[Test]
		public void Test_Field_GetThing()
		{
			Field f = new Field( 14 );

			Assert.AreEqual( 14, f.things.Count );

			int someId = f.things[0].id;
			int someIdNF = 68710;

			Assert.AreEqual( someId, f.GetThing( someId ).id );
			Assert.IsNull( f.GetThing( someIdNF ) );
		}

		[Test]
		public void Test_Field_DrawingUtil()
		{
			Field f = new Field( 14 );

			Bitmap b = f.Draw( new Size( 100, 100 ) );

			Assert.AreEqual( 100, b.Width );
			Assert.AreEqual( 100, b.Height );
		}

	}

}//ns
