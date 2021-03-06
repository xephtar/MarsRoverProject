using MarsRover.Models;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace MarsRover
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            var path = Path.Combine(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\")), "TestInput1.txt");
            var planetName = "Mars";
            if (args.Any())
            {
                try
                {
                    path = args[0];
                }
                catch (FileNotFoundException) { throw new FileNotFoundException(); };

                if (args.Length == 2)
                {
                    planetName = args[1];
                }
            }

            await ReadFileAndMoveRoversAsync(path, planetName);
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

        public static async Task ReadFileAndMoveRoversAsync(string path, string planetName)
        {
            if (File.Exists(path))
            {
                TextReader input = File.OpenText(path);
                int lineCounter = 0;
                Plateau PlateauOnMars = new Plateau();
                for (string line; (line = input.ReadLine()) != null; lineCounter++)
                {
                    string[] variables = line.Split(' ');
                    if (lineCounter == 0)
                    {
                        // If it is first line
                        // Create Plateau
                        int XMax = int.Parse(variables[0]);
                        int YMax = int.Parse(variables[1]);

                        PlateauOnMars = new Plateau(XMax, YMax, planetName);

                        continue;
                    }

                    if (IsEven(lineCounter))
                    {
                        // If the line count is even
                        // It is movement instruction for rover
                        int RoverID = PlateauOnMars.RoverCount - 1;
                        PlateauOnMars.MoveRoverWithIDAndSequence(RoverID, line);
                    }
                    else
                    {
                        // If the line count is odd
                        // It is a new rover to create
                        int XPos = int.Parse(variables[0]);
                        int YPos = int.Parse(variables[1]);
                        string Direction = variables[2];
                        PlateauOnMars.AddRoverWithInformation(XPos, YPos, Direction);
                    }
                }
                await File.WriteAllLinesAsync(Path.Combine(Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\")), "Output.txt"), PlateauOnMars.GetInformationOfRovers());
            }
            else
            {
                throw new FileNotFoundException();
            }
        }
    }
}