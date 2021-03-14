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

![alt text](https://devblogs.microsoft.com/visualstudio/wp-content/uploads/sites/4/2019/05/Visual-Studio-2019-Start-Window.png)

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

If you are using Visual Studio, you should open MarsRover.sln.
Then you can build the solution as seen in below.

![alt text](https://ibb.co/Jx45pKd)
