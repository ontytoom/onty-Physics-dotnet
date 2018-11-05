using System;
using System.Drawing;
using NUnit.Framework;
using NUnit.Framework.Constraints;

using Onty.LibMath.Vectors;

using Onty.Physics.Domain;
using Onty.Physics.Util;


namespace Onty.Physics.Tests
{

	[TestFixture]
	public class Test_Thing
	{

		[Test]
		public void Test_Thing_CtorDef()
		{
			Thing thing = new Thing();

			Assert.IsTrue( thing.id > -1 );

			Assert.IsNull( thing.location );
			Assert.IsNull( thing.myField );
			Assert.IsNull( thing.velocity );

			Assert.AreEqual( thing.size, 0.0 );
			Assert.IsNotNull( thing.color );
		}


		[Test]
		public void Test_Thing_CtorMain()
		{
			Field f = new Field();
			Location2d loc = new Location2d();
			Velocity2d vel = new Velocity2d();
			double size = 14.0;

			Thing thing = new Thing( f.CurrentState, loc, vel, size );

			Assert.IsTrue( thing.id > -1 );
			Assert.AreSame( thing.location, loc );
			Assert.AreSame( thing.velocity, vel );
			Assert.AreEqual( thing.size, size );
		}


		[Test]
		public void Test_Thing_ColorForSerialization_Get()
		{
			Field f = new Field();
			Location2d loc = new Location2d();
			Velocity2d vel = new Velocity2d();
			double size = 14.0;

			Thing thing = new Thing( f.CurrentState, loc, vel, size );

			Assert.AreEqual( thing.color.R, thing.ColorForSerialization.red );
			Assert.AreEqual( thing.color.G, thing.ColorForSerialization.green );
			Assert.AreEqual( thing.color.B, thing.ColorForSerialization.blue );
		}


		[Test]
		public void Test_Thing_ColorForSerialization_Set()
		{
			Field f = new Field();
			Location2d loc = new Location2d();
			Velocity2d vel = new Velocity2d();
			double size = 14.0;

			Thing thing = new Thing( f.CurrentState, loc, vel, size );

			ColorSrz colorSrz = new ColorSrz();
			colorSrz.red = 68;
			colorSrz.green = 71;
			colorSrz.blue = 14;

			thing.ColorForSerialization = colorSrz;

			Assert.AreEqual( thing.color.R, thing.color.R );
			Assert.AreEqual( thing.color.G, thing.color.G );
			Assert.AreEqual( thing.color.B, thing.color.B );
		}


		[Test]
		public void Test_Thing_MakeCopy()
		{
			Field f = new Field();
			Location2d loc = new Location2d();
			Velocity2d vel = new Velocity2d();
			double size = 14.0;

			Thing thing = new Thing( f.CurrentState, loc, vel, size );

			Thing copy = thing.MakeCopy();

			Assert.AreEqual( thing.id, copy.id );
			//TODO: also need to test Id which includes FieldState's time

			Assert.AreEqual( thing.color, copy.color );
			Assert.AreEqual( thing.size, copy.size );
			Assert.AreEqual( thing.Mass, copy.Mass );   // calculated
			Assert.AreEqual( thing.location, copy.location );
			Assert.AreEqual( thing.velocity, copy.velocity );

			Assert.IsNull( copy.gravityNet );
			Assert.IsNull( copy.gravityComponents );

		}


		[Test]
		public void Test_Thing_Mass()
		{
			Field f = new Field();
			Location2d loc = new Location2d();
			Velocity2d vel = new Velocity2d();
			double size = 14.0;

			Thing thing = new Thing( f.CurrentState, loc, vel, size );

			double expectedMass = size * size * Math.PI;

			Assert.AreEqual( expectedMass, thing.Mass );
		}


		[Test]
		public void Test_Thing_OptimalDeltaT()
		{
			Field f = new Field();
			Location2d loc = new Location2d();
			Velocity2d vel = new Velocity2d( 10, 0 );
			double size = 10.0;

			Thing thing = new Thing( f.CurrentState, loc, vel, size );

			decimal expectedDeltaT = 1.0m;

			Assert.AreEqual( expectedDeltaT, thing.CalculateOptimalDeltaT() );
		}


		[Test]
		public void Test_Thing_OptimalDeltaT2()
		{
			Field f = new Field();
			Location2d loc = new Location2d();
			Velocity2d vel = new Velocity2d( 0, 28 );
			double size = 14.0;

			Thing thing = new Thing( f.CurrentState, loc, vel, size );

			decimal expectedDeltaT = 0.5m;

			Assert.AreEqual( expectedDeltaT, thing.CalculateOptimalDeltaT() );
		}


	}//class Test_Thing

}//ns

