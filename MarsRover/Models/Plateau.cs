using System;
using System.Collections.Generic;
using static MarsRover.Enums;

namespace MarsRover
{
    internal class Plateau
    {
        public int XMax;
        public int YMax;
        public string PlanetName { get; set; }
        public List<Rover> Rovers { get; set; }
        public int RoverCount { get; set; }

        // Empty constructor
        public Plateau() { }

        public Plateau(int XMax, int YMax, string PlanetName = "Mars")
        {
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
                Rovers.Add(new Rover(XPos, YPos, DirectionOfRover, RoverCount));
                RoverCount += 1;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("{0} is not a member of the Direction enumeration.", direction);
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
                                Console.WriteLine("Not valid!");
                            }
                            break;

                        default:
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("The rover is not found!", e);
            }
        }
    }
}