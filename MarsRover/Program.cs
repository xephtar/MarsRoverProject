﻿using MarsRover.Models;
using System;
using System.IO;
using System.Linq;

namespace MarsRover
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var path = "Inputs/TestInput1.txt";
            if (args.Any())
            {
                try
                {
                    path = args[0];
                }
                catch (FileNotFoundException) { throw new FileNotFoundException(); };
            }

            ReadFileAndMoveRovers(path);
        }

        public static bool IsEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void ReadFileAndMoveRovers(string path)
        {
            if (File.Exists(path))
            {
                TextReader input = File.OpenText(path);
                int lineCounter = 0;
                Plateau PlateauOnMars = new Plateau();
                for (string line; (line = input.ReadLine()) != null; lineCounter++)
                {
                    if (lineCounter == 0)
                    {
                        string[] variables = line.Split(' ');
                        int XMax = int.Parse(variables[0]);
                        int YMax = int.Parse(variables[1]);
                        if (args.Length == 2)
                        {
                            PlateauOnMars = new Plateau(XMax, YMax, args[1]);
                        }
                        else
                        {
                            PlateauOnMars = new Plateau(XMax, YMax, "Mars");
                        }
                        continue;
                    }

                    if (IsEven(lineCounter))
                    {
                        int RoverID = PlateauOnMars.RoverCount - 1;
                        PlateauOnMars.MoveRoverWithIDAndSequence(RoverID, line);
                    }
                    else
                    {
                        string[] variables = line.Split(' ');
                        int XPos = int.Parse(variables[0]);
                        int YPos = int.Parse(variables[1]);
                        string Direction = variables[2];
                        PlateauOnMars.AddRoverWithInformation(XPos, YPos, Direction);
                    }
                }
                PlateauOnMars.GetInformationOfRovers();
            }
        }
    }
}