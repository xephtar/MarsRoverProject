# MarsRover

## Description

A squad of robotic rovers are to be landed by NASA on a plateau on Mars. This plateau, which is
curiously rectangular, must be navigated by the rovers so that their on board cameras can get a
complete view of the surrounding terrain to send back to Earth.

A rover's position and location is represented by a combination of x and y co-ordinates and a letter
representing one of the four cardinal compass points. The plateau is divided up into a grid to
simplify navigation. An example position might be 0, 0, N, which means the rover is in the bottom
left corner and facing North.

In order to control a rover, NASA sends a simple string of letters. The possible letters are 'L', 'R' and
'M'. 'L' and 'R' makes the rover spin 90 degrees left or right respectively, without moving from its
current spot. 'M' means move forward one grid point, and maintain the same heading.
Assume that the square directly North from (x, y) is (x, y+1).


## Installation

If you are using Visual Studio 2019, you can select "Clone repository". Then you should paste the below txt.

```console
https://github.com/xephtar/MarsRoverProject.git
```

Or you can clone the repository to any directory and open the MarsRover.sln with "Open a project or solution" option.

```console
git clone https://github.com/xephtar/MarsRoverProject.git
```

![visual_studio_start_window](https://devblogs.microsoft.com/visualstudio/wp-content/uploads/sites/4/2019/05/Visual-Studio-2019-Start-Window.png)

## How to run

You should use .NET Core framework.

It takes `.txt file` as an input
If you are using cmd to run project, you should follow the steps.

```console
git clone https://github.com/xephtar/MarsRoverProject.git
cd MarsRoverProject
cd MarsRover
dotnet run [file_path] [planet_name]
```
If you do not `give file_path`argument, it will use `TestInput1.txt` at `MarsRover` directory.
The planet name is also optional. Its default is "Mars".

If you are using Visual Studio, you should open `MarsRover.sln`.
Then you can build the solution as seen in below.

![how_to_build_sln](https://i.ibb.co/WDwgz63/build.jpg)

You can give arguments like seen below steps.

![open_properties](https://i.ibb.co/hRXfQmP/argument.jpg)

![give_arguments](https://i.ibb.co/zmhPYs0/argument1.jpg)

Or you can change from `launchSettings.json`

## Output

It writes the output of the program into `Output.txt` at `MarsRover` directory.

## Unit Tests

You can run unit tests as seen below.
There are 17 unit test for two classes.

![unit_tests](https://i.ibb.co/x3XcfHL/unit.jpg)

