using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Sprint_0_Warm_Up;

namespace UnitTestProjectAV
{
    [TestClass]
    public class ToyPlaneTests
    {
        ToyPlane test;

        /// <summary>
        /// Write some airpost tests
        /// </summary>
        [TestMethod]
        public void ToyPlaneWindUp()
        {
            //Arrange
            test = new ToyPlane();

            //Act
            string beforeWindUp = test.getWindUpString();
            test.WindUp();
            string afterWindUp = test.getWindUpString();

            //Assert
            Assert.AreEqual(beforeWindUp, $"{test.ToString()} string is not wound up.");
            Assert.AreEqual(afterWindUp, $"{test.ToString()} string is wound up.");
        }

        [TestMethod]
        public void ToyPlaneUnwind()
        {
            //Arrange
            test = new ToyPlane();

            //Act
            test.WindUp();
            string beforeUnwind = test.getWindUpString();
            test.Unwind();
            string afterUnwind = test.getWindUpString();

            //Assert
            Assert.AreEqual(beforeUnwind, $"{test.ToString()} string is wound up.");
            Assert.AreEqual(afterUnwind, $"{test.ToString()} string is not wound up.");
        }

        [TestMethod]
        public void ToyPlaneStartEngine()
        {
            //Arrange
            test = new ToyPlane();

            //Act
            test.StartEngine();
            string engineNoWindup = test.About();
            test.WindUp();
            test.StartEngine();
            string engineWindup = test.About();

            //Assert
            Assert.AreEqual(engineNoWindup, $"This {test.ToString()} has a max altitude of 50 ft.\nIt's current altitude is 0 ft.\n{test.Engine.ToString()} is not started.");
            Assert.AreEqual(engineWindup, $"This {test.ToString()} has a max altitude of 50 ft.\nIt's current altitude is 0 ft.\n{test.Engine.ToString()} is started.");
        }

        [TestMethod]
        public void ToyPlaneMaxAltitude()
        {
            //Arrange
            test = new ToyPlane();

            //Act
            string about = test.About();

            //Assert
            Assert.AreEqual(about, $"This {test.ToString()} has a max altitude of 50 ft.\nIt's current altitude is 0 ft.\n{test.Engine.ToString()} is not started.");
        }
    }
}
