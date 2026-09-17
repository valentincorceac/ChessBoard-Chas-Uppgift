# ChessBoard-Chas-Uppgift
C# console Application that renders a chessboard

## Prerequisites
```sh
.NET10.0 
```
---

## Instructions
1. Clone the repo.
    ```sh
    git clone https://github.com/valentincorceac/ChessBoard-Chas-Uppgift.git
    ```
2. Make sure the project builds
    ```sh
    dotnet build
    ```
3. Run the project
   ```sh
   dotnet run
   ```
---

## Usage example
The program lets the user input a number between 3 - 50.

<img width="509" height="116" alt="Example1" src="https://github.com/user-attachments/assets/a3d79429-3528-4b64-bd05-c7eacf6b4abe" />

It then renders a chessboard of the given size.

<img width="482" height="295" alt="Example2" src="https://github.com/user-attachments/assets/cbe0daaf-bd6e-464a-bbc4-861ab9509a95" />

---


## Packages

The projects uses SpectreConsole to improve visuals and render the chess board in black and white squares.

[SpectreConsole](https://spectreconsole.net)

---

## Code Structure
The program is made of a class with two methods.

GetSize will ask for user input and check for valid value and that the console window width is large enough.

Draw takes in board size as a variable and will render a chess board based on the size given.

## Working with git

We worked in a zoom call sharing the screen and taking turns programming and then commiting to main branch.

We engineered a merge conflict by creating a test branch and making conflicting changes then merging the two branches together.

## Technical choices

To render the chess board we use a nested for loop that takes the board size value and renders based on that size. 


To check for user input we use a while loop that runs as long as one of these three things are false 
1. the user input as a number
2. the number is between 3 - 50
3. The console window width is bigger than the expected render size.





