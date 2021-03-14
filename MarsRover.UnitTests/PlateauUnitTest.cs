using MarsRover.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MarsRover.UnitTests
{
    [TestClass]
    public class PlateauUnitTest
    {
        private Plateau _validPlateau;

        public PlateauUnitTest()
        {
            _validPlateau = new Plateau(6, 6, "Mars");
        }

        [TestMethod]
        public void MaximumValuesOfPlateauShouldNotBeNegativeValues()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Plateau(-1, -2, "Mars"));
        }

        [TestMethod]
        public void AddedRoverShouldBeValidDirection()
        {
            Assert.ThrowsException<ArgumentException>(() => _validPlateau.AddRoverWithInformation(2, 2, "Z"));
        }

        [TestMethod]
        public void AddedRoverLocationShouldBeInsidePlateau()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _validPlateau.AddRoverWithInformation(7, 7, "N"));
        }

        [TestMethod]
        public void PlateauShouldContainRoverToMoveWithSequence()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _validPlateau.MoveRoverWithIDAndSequence(0, "LLMRM"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "The movement is not valid. It should be L, R or M!")]
        public void SequenceShouldContainValidMoves()
        {
            _validPlateau.AddRoverWithInformation(3, 3, "N");
            _validPlateau.MoveRoverWithIDAndSequence(_validPlateau.RoverCount, "Z");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "The rover is not found!")]
        public void RoverIdShouldBeValid()
        {
            _validPlateau.AddRoverWithInformation(3, 3, "N");
            _validPlateau.MoveRoverWithIDAndSequence(2, "MLR");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "The rover can not move! It is out of plateau.")]
        public void RoverCanNotMoveToOutOfPlateauWithGivenMoveSequence()
        {
            _validPlateau.AddRoverWithInformation(_validPlateau.XMax, _validPlateau.YMax, "N");
            _validPlateau.MoveRoverWithIDAndSequence(0, "MLR");
        }
    }
}