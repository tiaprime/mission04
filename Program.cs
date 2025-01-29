// See https://aka.ms/new-console-template for more information


using System.Diagnostics.Metrics;
using mission04;


BoardFunctions bf = new BoardFunctions();


string[,] boardArray = { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };

string user1_input = "";

List<string> validGuess = new List<string> {"1","2", "3", "4", "5", "6", "7", "8", "9"};

bool gameOver = false;

int gameCounter = 0;
string playerSym = "";
string playerNum = "0";

Console.WriteLine("Welcome to Tic Tac Toe!");
Console.WriteLine();
Console.WriteLine("Player 1 is X, Player 2 is O");
Console.WriteLine();

Console.WriteLine("Player 1 goes first");
Console.WriteLine();

//THE GAME PLAY LOOP
//this is a test

do { 

    // switchs players turn
    if (gameCounter % 2 == 0)
    {
        playerSym = "X";
        playerNum = "1";
    }
    else
    {
        playerSym = "O";
        playerNum = "2";
    }


bool advance = false;

do   // VALIDATE INPUT
{
    //PRINT THE GAME BOARD
    bf.PrintBoard(boardArray);
    

    Console.WriteLine("Player "+ playerNum + ", please enter a number 1-9 to place your "+ playerSym);
    user1_input = Console.ReadLine();
    //user1_input = "2";

    if (!validGuess.Contains(user1_input))
    {
        Console.WriteLine("Invalid input");
        Console.WriteLine("Please refer to the game board for avabipe spot.");
    }
    else
    {
        advance = true;
    }
} while (!advance);



// UPDATE THE BOARD
int rows = boardArray.GetLength(0);  // i is ROW
int columns = boardArray.GetLength(1);  // j is COL

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        if (boardArray[i, j] == user1_input)
        {
            boardArray[i, j] = playerSym; 
            validGuess.Remove(user1_input); // removed used number

        }

        Console.Write(boardArray[i, j] + " ");
    }
}
    gameCounter++;

} while (!gameOver);