using MarsRovers.Business;
using System;
using Xunit;

namespace MarsRoversTest
{
    public class UnitTest
    {
        [Fact]
        public void TurnLeft()
        {
            #region Arrange
            Rover rover = new Rover("1 2 N");
            #endregion

            #region Act
            rover.TurnLeft();
            #endregion

            #region Assert
            Assert.Equal('W', rover.direction);
            #endregion


        }

        [Fact]
        public void TurnRight()
        {
            #region Arrange
            Rover rover = new Rover("1 2 N");
            #endregion

            #region Act
            rover.TurnRight();
            #endregion

            #region Assert
            Assert.Equal('E', rover.direction);
            #endregion


        }

        [Fact]
        public void MoveForward()
        {

            #region Arrange
            Rover rover = new Rover("1 2 N");
            #endregion

            #region Act
            rover.MoveForward();
            #endregion

            #region Assert
            Assert.Equal(3, rover.coordinateY);
            #endregion


        }

        [Fact]
        public void MoveWithNasaCommand()
        {
            #region Arrange
            Rover rover = new Rover("1 2 N");
            #endregion


            #region Act
            rover.MovewithNasaCommand("LMLMLMLMM");
            #endregion

            #region Assert
            Assert.Equal("1 3 N", rover.coordinateX + " " + rover.coordinateY + " " + rover.direction);
            #endregion

        }
    }
}
