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
[SpectreConsole](https://spectreconsole.net)

---

## Code Structure
The program is made of a class with two methods.
GetSize will ask for user input and check for valid value and that the console window width is large enough.
Draw takes in board size as a variable and will render a chess board based on the size given.




