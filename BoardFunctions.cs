using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mission04
{
    internal class BoardFunctions
    {
        // Function to print a board
        public void PrintBoard(char[][] boardArray)
        {
            // Loop through the board and print each element
            for (int i = 0; i < boardArray.Count(); i++)
            {
                for (int j = 0; j < boardArray[i].Count(); j++)
                {
                    Console.Write(boardArray[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        public (bool, char) CheckWinner(char[][] boardArray)
        {
            bool winner = false;
            char winValue = ' ';

            //If statements to only check for a winner if a winner hasn't been found yet
            // vvvv
            //Check Horizonatal win
            if (winner != true)
            {
                for (int i = 0; i < boardArray.Count(); i++)
                {
                    winValue = boardArray[i][0];

                    if (boardArray[i][1] == winValue && boardArray[i][1] == winValue)
                    {
                        winner = true;
                    }
                }
            }

            //Check Vertical win
            if (winner != true)
            {
                for (int i = 0; i < boardArray.Count(); i++)
                {
                    winValue = boardArray[0][i];

                    if (boardArray[1][i] == winValue && boardArray[2][i] == winValue)
                    {
                        winner = true;
                    }
                }
            }

            //Check left Diagonal win
            if (winner != true)
            {
                winValue = boardArray[0][0];

                if (boardArray[1][1] == winValue && boardArray[2][2] == winValue)
                {
                    winner = true;
                }
            }

            //Check right Diagonal win
            if (winner != true)
            {
                winValue = boardArray[0][2];

                if (boardArray[1][1] == winValue && boardArray[2][0] == winValue)
                {
                    winner = true;
                }
            }
     
            
            return (winner, winValue);


        }
    }
}
