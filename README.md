# Simplex Calculator

A desktop application that can solve linear programming problems using the simplex method and C# winforms.

## Introduction

Linear programming is a technique for optimizing a linear objective function subject to a set of linear constraints. The simplex method is an algorithm for finding the optimal solution of a linear programming problem, or determining that the problem is unbounded or infeasible.

This project is a simplex calculator that can perform basic arithmetic operations using the simplex method and C# winforms. The user can enter the objective function and the constraints, and the program will display the optimal solution and the steps of the algorithm.

## Installation and Usage

To install and run this project, you will need Visual Studio and the .NET Framework, which are tools for developing Windows applications. You can download them from these web pages: [Visual Studio](https://visualstudio.microsoft.com/), [.NET Framework](https://dotnet.microsoft.com/en-us/).

To install the project, follow these steps:

- Clone this repository to your local machine using this command:

```bash
git clone https://github.com/Zakariathr22/SimplexCalculator.git
```

- Open the solution file `WinFormsApp1.sln` in Visual Studio.
- Build the solution by clicking on `Build -> Build Solution` in the menu bar.
- Run the project by clicking on `Debug -> Start Debugging` in the menu bar, or pressing `F5` on your keyboard.

To use the project, follow these steps:

- Enter the number of variables and constraints in the text boxes at the top of the window, and click on `Next` to create the input table.
- Enter the coefficients of the objective function and the constraints in the input table, and select the optimization type (`Maximize` or `Minimize`) from the drop-down menu.
- Click on `Solve` to start the simplex method and display the output table.
- View the optimal solution and the steps of the algorithm in the output table.

## Screenshots

Here are some screenshots of the project:

- Specifying the linear problem:
![First Window](/WinFormsApp1/Images/Form1.png?raw=true "Entering the linear problem")

- Standardized form and first tableau:
![Solution](/WinFormsApp1/Images/Form2_1.png?raw=true "Standard form and first table")

- Simplex method Iterations:
![Solution](/WinFormsApp1/Images/Form2_2.png?raw=true "Simplex method Iterations")

- The optimal solution:
![Solution](/WinFormsApp1/Images/Form2_3.png?raw=true "The optimal solution")

## Disclaimer

I apologize if the code is complex or hard to understand. I did this project in a very short time without planning or organizing. I know that this is not a good practice, and I hope to improve my coding skills and habits in the future. If you have any questions or suggestions, please feel free to contact me or open an issue. Thank you for your patience and interest in my project. 😊

## Contributing

This project is open for contributions. If you want to contribute, please follow these steps:

- Fork this repository and clone it to your local machine.
- Create a new branch for your feature or bug fix.
- Write your code and test it.
- Push your changes to your fork and create a pull request.
- Wait for the maintainers to review and merge your pull request.

Please write clear and concise commit messages.
