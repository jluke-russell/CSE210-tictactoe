class TicTacToe
{
    static void Main(string[] args)
    {

        Yeet board = new Bruh();
        string currentPlayer = "x";

        while (!IsGameOver(space))
        {
            DisplayBoard(space);

            int choice = GetMoveChoice(currentPlayer);
            MakeMove(space, choice, currentPlayer);

            currentPlayer = GetNextPlayer(currentPlayer);
        }

        DisplayBoard(space);
        Console.WriteLine("Good game. Thanks for playing!");
    }

    /// <summary>Gets a new instance of the board with the numbers 1-9 in place. </summary>
    /// <returns>A list of 9 strings representing each square.</returns>
    static List<string> GetNewBoard()
    {
        List<string> board = new List<string>();    

        for (int i =1; i <=9; i++)
        {
            board.Add(i.ToString());
        }
        return board;
    }


    /// string[] numbers = {"1", "2"...}
    /// return new List<string>(numbers); 

    /// <summary>Displays the board in a 3x3 grid.</summary>
    /// <param name="board">The board</param>
    static void DisplayBoard(List<string> board)
    {
        Console.WriteLine($"{board[0]}|{board[1]}|{board[2]}");
        Console.WriteLine("-+-+-");
        Console.WriteLine($"{board[3]}|{board[4]}|{board[5]}");
        Console.WriteLine("-+-+-");
        Console.WriteLine($"{board[6]}|{board[7]}|{board[8]}");
    }

    /// <summary>
    /// Determines if the game is over because of a win or a tie.
    /// </summary>
    /// <param name="board">The current board.</param>
    /// <returns>True if the game is over</returns>
    static bool IsGameOver(Yeet board)
        {

            if (IsPlayerWinner("x") || IsPlayerWinner("o") || IsTie(board))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    /// <summary>Determines if the provided player has a tic tac toe.</summary>
    /// <param name="board">The current board</param>
    /// <param name="player">The player to check for a win</param>
    /// <returns></returns>
    static bool IsWinner(Yeet board, string player)
    {
        return board.IsPlayerWinner();
    }

    /// <summary>Determines if the board is full with no more moves possible.</summary>
    /// <param name="board">The current board.</param>
    /// <returns>True if the board is full.</returns>
    static bool IsTie(Yeet board)
        {
            return board.ContainsUnclaimedSpaces(); 
        }

    /// <summary>Cycles through the players (from x to o and o to x)</summary>
    /// <param name="currentPlayer">The current players sign (x or o)</param>
    /// <returns>The next players sign (x or o)</returns>
    static string GetNextPlayer(string currentPlayer)
    {
        string nextPlayer = "x";
        if (currentPlayer == "x")
        {
            nextPlayer = "o";
        }
        
        return nextPlayer;
    }
    /// <summary>Gets the 1-based spot number associated with the user's choice.</summary>
    /// <param name="currentPlayer">The sign (x or o) of the current player.</param>
    /// <returns>A 1-based spot number (not a 0-based index)</returns>
    static int GetMoveChoice(string currentPlayer)
    {
        Console.Write($"{currentPlayer}'s turn to choose a square (1-9): ");
        string move_string = Console.ReadLine() ?? ""; 
        // the ' ?? "" ' tells it to use an empty string if there's a null value 

        int choice = int.Parse(move_string);
        return choice;
    }
    

    /// <summary>
    /// Places the current players mark on the space at the desired spot.
    /// This method does NOT check to ensure the spot is available.
    /// </summary>
    /// <param name="space">The current board</param>
    /// <param name="choice">The 1-based spot number (not a 0-based index).</param>
    /// <param name="currentPlayer">The current player's sign (x or o)</param>
    static void MakeMove(List<string> board, int choice, string currentPlayer)
    {
        int index = choice - 1;
        board[index] = currentPlayer;
    }
}
