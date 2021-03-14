using MarsRover.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static MarsRover.Models.Enums;

namespace MarsRover.UnitTests
{
    [TestClass]
    public class RoverUnitTest
    {
        public bool CreateRoverAndMoveWithGivenDirection(Direction direction)
        {
            int XMax = 3;
            int YMax = 3;
            Rover RoverTest = new Rover(1, 1, direction, 0);
            if (RoverTest.IsMoveValid(XMax, YMax))
            {
                RoverTest.Move();
                return true;
            }
            return false;
        }

        [TestMethod]
        public void RoverLocationShouldNotBeNegativeValue()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Rover(-1, -2, Direction.N, 0));
        }

        [TestMethod]
        public void RoverIDShouldNotBeNegativeValue()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Rover(1, 2, Direction.N, -2));
        }

        [TestMethod]
        public void RoverShouldNotMoveToNegativeXLocation()
        {
            int XMax = 5;
            int YMax = 5;
            Rover RoverTest = new Rover(0, 0, Direction.W, 0);
            Assert.IsFalse(RoverTest.IsMoveValid(XMax, YMax));
        }

        [TestMethod]
        public void RoverShouldNotMoveToNegativeYLocation()
        {
            int XMax = 5;
            int YMax = 5;
            Rover RoverTest = new Rover(0, 0, Direction.S, 0);
            Assert.IsFalse(RoverTest.IsMoveValid(XMax, YMax));
        }

        [TestMethod]
        public void RoverShouldNotMoveToGreaterThanXMaxOfPlateau()
        {
            int XMax = 5;
            int YMax = 5;
            Rover RoverTest = new Rover(XMax, YMax, Direction.E, 0);
            Assert.IsFalse(RoverTest.IsMoveValid(XMax, YMax));
        }

        [TestMethod]
        public void RoverShouldNotMoveToGreaterThanYMaxOfPlateau()
        {
            int XMax = 5;
            int YMax = 5;
            Rover RoverTest = new Rover(XMax, YMax, Direction.N, 0);
            Assert.IsFalse(RoverTest.IsMoveValid(XMax, YMax));
        }

        [TestMethod]
        public void RoverShouldMoveNorthIfMoveIsValid()
        {
            Assert.IsTrue(CreateRoverAndMoveWithGivenDirection(Direction.N));
        }

        [TestMethod]
        public void RoverShouldMoveEastIfMoveIsValid()
        {
            Assert.IsTrue(CreateRoverAndMoveWithGivenDirection(Direction.E));
        }

        [TestMethod]
        public void RoverShouldMoveWestIfMoveIsValid()
        {
            Assert.IsTrue(CreateRoverAndMoveWithGivenDirection(Direction.W));
        }

        [TestMethod]
        public void RoverShouldMoveSouthIfMoveIsValid()
        {
            Assert.IsTrue(CreateRoverAndMoveWithGivenDirection(Direction.S));
        }
    }
}