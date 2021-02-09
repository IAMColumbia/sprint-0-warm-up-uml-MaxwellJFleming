using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Sprint_0_Warm_Up;

namespace UnitTestProjectAV
{
    [TestClass]
    public class AirportTests
    {
        /// <summary>
        /// Write some airpost tests
        /// </summary>
        [TestMethod]
        public void AirportSingularLand()
        {
            //Arrange
            Airport airport = new Airport("TEST", 3);
            Airplane plane = new Airplane();

            //Act
            plane.FlyUp();
            airport.Land(plane);

            //Assert
            Assert.IsFalse(plane.IsFlying);
            Assert.AreEqual(plane.CurrentAltitude, 0);
            Assert.AreEqual(airport.Vehicles.Count, 1);
        }

        [TestMethod]
        public void AirportMultipleLand()
        {
            //Arrange
            Airport airport = new Airport("TEST", 3);
            Airplane plane = new Airplane();
            Airplane plane1 = new Airplane();
            Airplane plane2 = new Airplane();
            List<AerialVehicle> planesToLand = new List<AerialVehicle>() { plane, plane1, plane2 };

            //Act
            airport.Land(planesToLand);

            //Assert
            Assert.IsFalse(plane.IsFlying);
            Assert.IsFalse(plane1.IsFlying);
            Assert.IsFalse(plane2.IsFlying);
            Assert.AreEqual(airport.Vehicles.Count, 3);
        }
    }
}
