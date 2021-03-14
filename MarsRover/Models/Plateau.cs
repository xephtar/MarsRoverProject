using System;
using System.Collections.Generic;
using static MarsRover.Models.Enums;

namespace MarsRover.Models
{
    public class Plateau
    {
        public int XMax;
        public int YMax;
        public string PlanetName { get; set; }
        public List<Rover> Rovers { get; set; }
        public int RoverCount { get; set; }

        // Empty constructor
        public Plateau() { }

        public Plateau(int XMax, int YMax, string PlanetName)
        {
            if (XMax < 0 || YMax < 0)
            {
                throw new ArgumentOutOfRangeException("XMax or YMax of plateau should not be less than 0!");
            }
            Rovers = new List<Rover>();
            this.XMax = XMax;
            this.YMax = YMax;
            this.PlanetName = PlanetName;
            RoverCount = 0;
        }

        public void AddRoverWithInformation(int XPos, int YPos, string direction)
        {
            try
            {
                Direction DirectionOfRover = (Direction)Enum.Parse(typeof(Direction), direction);
                if (XPos > XMax || YPos > YMax)
                {
                    throw new ArgumentOutOfRangeException();
                }
                Rovers.Add(new Rover(XPos, YPos, DirectionOfRover, RoverCount));
                RoverCount += 1;
            }
            catch (ArgumentOutOfRangeException)
            {
                throw new ArgumentOutOfRangeException("Position of rover is not inside the plateau!");
            }
            catch (ArgumentException)
            {
                throw new ArgumentException("Given direction is not valid direction. It should N, W, E or S!");
            }
        }

        public void GetInformationOfRovers()
        {
            foreach (Rover rover in Rovers)
            {
                rover.GetInformation();
            }
        }

        public void MoveRoverWithIDAndSequence(int ID, string sequence)
        {
            try
            {
                foreach (char move in sequence)
                {
                    switch (move)
                    {
                        case 'L':
                            Rovers[ID].Rotate(Movement.L);
                            break;

                        case 'R':
                            Rovers[ID].Rotate(Movement.R);
                            break;

                        case 'M':
                            if (Rovers[ID].IsMoveValid(XMax, YMax))
                            {
                                Rovers[ID].Move();
                            }
                            else
                            {
                                throw new ArgumentOutOfRangeException("The rover can not move! It is out of plateau.");
                            }
                            break;

                        default:
                            throw new ArgumentException();
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                throw new ArgumentOutOfRangeException("The rover is not found!");
            }
            catch (ArgumentException)
            {
                throw new ArgumentException("The movement is not valid. It should be L, R or M!");
            }
        }
    }
}