# MarsRover

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

If you are using cmd to run project, you should follow the steps.

```console
git clone https://github.com/xephtar/MarsRoverProject.git
cd MarsRoverProject
cd MarsRover
dotnet run [file_path] [planet_name]
```
If you do not `give file_path`argument, it will use `TestInput1.txt` at `Inputs` directory.
The planet name is also optional. Its default is "Mars".

If you are using Visual Studio, you should open `MarsRover.sln`.
Then you can build the solution as seen in below.

![how_to_build_sln](https://i.ibb.co/WDwgz63/build.jpg)

You can give arguments like seen below steps.

![open_properties](https://i.ibb.co/hRXfQmP/argument.jpg)

![give_arguments](https://i.ibb.co/zmhPYs0/argument1.jpg)

## Unit Tests

You can run unit tests as seen below.
There are 17 unit test for two classes.

![unit_tests](https://i.ibb.co/x3XcfHL/unit.jpg)

