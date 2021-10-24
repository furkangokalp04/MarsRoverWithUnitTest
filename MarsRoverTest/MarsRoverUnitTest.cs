using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MarsRover;
using MarsRover.Model;

namespace MarsRoverTest
{
    [TestClass]
    public class MarsRoverUnitTest
    {
        Plateau plateau = new Plateau(5, 5);
        Position position = new Position(1, 2);
        [TestMethod]
        public void Test_SetPosition()
        {
            Rover rover = new Rover(plateau, position, DirectionEnum.N);

            MainRoverClass.SetPosition(rover, 1, 2, DirectionEnum.W);
            Assert.AreEqual(rover.heading, DirectionEnum.W);
        }
        [TestMethod]
        public void Test_TurnRight()
        {
            Rover rover = new Rover(plateau, position, DirectionEnum.N);

            DirectionEnum expectedDir = DirectionEnum.E;
            MainRoverClass.TurnRight(rover);
            Assert.AreEqual(rover.heading, expectedDir);
        }
        [TestMethod]
        public void Test_TurnRight2()
        {
            Rover rover = new Rover(plateau, position, DirectionEnum.S);

            DirectionEnum expectedDir = DirectionEnum.W;
            MainRoverClass.TurnRight(rover);
            Assert.AreEqual(rover.heading, expectedDir);
        }
        [TestMethod]
        public void Test_TurnLeft()
        {
            Rover rover = new Rover(plateau, position, DirectionEnum.N);

            DirectionEnum expectedDir = DirectionEnum.W;
            MainRoverClass.TurnLeft(rover);
            Assert.AreEqual(rover.heading, expectedDir);
        }
        [TestMethod]
        public void Test_TurnLeft2()
        {
            Rover rover = new Rover(plateau, position, DirectionEnum.S);

            DirectionEnum expectedDir = DirectionEnum.E;
            MainRoverClass.TurnLeft(rover);
            Assert.AreEqual(rover.heading, expectedDir);
        }
        [TestMethod]
        public void Test_Move()
        {
            Rover rover = new Rover(plateau, position, DirectionEnum.N);

            bool result = MainRoverClass.Move(rover);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Test_Move2()
        {
            Plateau plateau = new Plateau(5, 5);
            Position position = new Position(5, 6);
            Rover rover = new Rover(plateau, position, DirectionEnum.N);

            bool result = MainRoverClass.Move(rover);
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void Test_RunCommand()
        {
            Rover rover = new Rover(plateau, position, DirectionEnum.N);

            DirectionEnum expectedDir = DirectionEnum.W;
            MainRoverClass.RunCommand(rover, 'L');
            Assert.AreEqual(rover.heading, expectedDir);
        }
        [TestMethod]
        public void Test_RunCommand2()
        {
            Rover rover = new Rover(plateau, position, DirectionEnum.S);

            DirectionEnum expectedDir = DirectionEnum.W;
            MainRoverClass.RunCommand(rover, 'R');
            Assert.AreEqual(rover.heading, expectedDir);
        }
        [TestMethod]
        public void Test_CurentPosition()
        {
            Rover rover = new Rover(plateau, position, DirectionEnum.S);

            string expectedStr = MainRoverClass.CurrentPosition(rover);
            Assert.AreEqual("1 2 S", expectedStr);
        }
        [TestMethod]
        public void Test_ProcessX()
        {
            Rover rover = new Rover(plateau, position, DirectionEnum.N);

            Position expectedPosition = new Position(1, 3);

            MainRoverClass.Process(rover, "LMLMLMLMM");
            Assert.AreEqual(rover.position.x, expectedPosition.x);
        }
        [TestMethod]
        public void Test_ProcessY()
        {
            Rover rover = new Rover(plateau, position, DirectionEnum.N);

            Position expectedPosition = new Position(1, 3);

            MainRoverClass.Process(rover, "LMLMLMLMM");
            Assert.AreEqual(rover.position.y, expectedPosition.y);
        }
        [TestMethod]
        public void Test_ProcessX2()
        {
            Plateau plateau = new Plateau(5, 5);
            Position position = new Position(3, 3);
            Rover rover = new Rover(plateau, position, DirectionEnum.E);

            Position expectedPosition = new Position(5, 1);

            MainRoverClass.Process(rover, "MMRMMRMRRM");
            Assert.AreEqual(rover.position.x, expectedPosition.x);
        }
        [TestMethod]
        public void Test_ProcessY2()
        {
            Plateau plateau = new Plateau(5, 5);
            Position position = new Position(3, 3);
            Rover rover = new Rover(plateau, position, DirectionEnum.E);

            Position expectedPosition = new Position(5, 1);

            MainRoverClass.Process(rover, "MMRMMRMRRM");
            Assert.AreEqual(rover.position.y, expectedPosition.y);
        }
    }
}
