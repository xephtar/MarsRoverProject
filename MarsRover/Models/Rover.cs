using System;
using static MarsRover.Enums;

namespace MarsRover
{
    internal class Rover
    {
        public int ID { get; set; }

        // Represents location rover at coordinate system
        public Location CoordinatesOfRover { get; set; }

        // Represents where the rover's face is looking
        public Direction DirectionOfRover { get; set; }

        // Empty constructor
        public Rover()
        {
        }

        public Rover(int xPos, int yPos, Direction direction, int ID)
        {
            CoordinatesOfRover = new Location(xPos, yPos);
            DirectionOfRover = direction;
            this.ID = ID;
        }

        public void Move()
        {
            switch (DirectionOfRover)
            {
                case Direction.E:
                    CoordinatesOfRover.Update(1, 0);
                    break;

                case Direction.N:
                    CoordinatesOfRover.Update(0, 1);
                    break;

                case Direction.S:
                    CoordinatesOfRover.Update(0, -1);
                    break;

                case Direction.W:
                    CoordinatesOfRover.Update(-1, 0);
                    break;

                default:
                    break;
            }
        }

        public bool IsMoveValid(int XMax, int YMax)
        {
            if (CoordinatesOfRover.XPos == 0 && DirectionOfRover == Direction.W)
            {
                return false;
            }

            if (CoordinatesOfRover.YPos == 0 && DirectionOfRover == Direction.S)
            {
                return false;
            }

            if (CoordinatesOfRover.XPos == XMax && DirectionOfRover == Direction.E)
            {
                return false;
            }

            if (CoordinatesOfRover.YPos == YMax && DirectionOfRover == Direction.N)
            {
                return false;
            }

            return true;
        }

        public void Rotate(Movement movement)
        {
            if (movement == Movement.M)
            {
                throw new ArgumentException("M is not a rotation movement!");
            }
            switch (DirectionOfRover)
            {
                case Direction.E:
                    if (movement == Movement.L)
                    {
                        DirectionOfRover = Direction.N;
                    }
                    else
                    {
                        DirectionOfRover = Direction.S;
                    }
                    break;

                case Direction.N:
                    if (movement == Movement.L)
                    {
                        DirectionOfRover = Direction.W;
                    }
                    else
                    {
                        DirectionOfRover = Direction.E;
                    }
                    break;

                case Direction.W:
                    if (movement == Movement.L)
                    {
                        DirectionOfRover = Direction.S;
                    }
                    else
                    {
                        DirectionOfRover = Direction.N;
                    }
                    break;

                case Direction.S:
                    if (movement == Movement.L)
                    {
                        DirectionOfRover = Direction.E;
                    }
                    else
                    {
                        DirectionOfRover = Direction.W;
                    }
                    break;

                default:
                    break;
            }
        }

        public void GetInformation()
        {
            Console.WriteLine("{0} {1} {2}", CoordinatesOfRover.XPos, CoordinatesOfRover.YPos, DirectionOfRover);
        }
    }
}