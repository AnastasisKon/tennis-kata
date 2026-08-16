namespace Tennis;

public class TennisGame
{
    private int Player1Score = 0;
    private int Player2Score = 0;

    private bool VerboseFlag = true;

    public void AddPointPlayer1()
    {
        if ((Player2Score - Player1Score >= 2) && Player1Score >= 2)  // So it does not add points if the game has ended
        {   
            if (VerboseFlag)
            {
                Console.WriteLine("Warning: The game has already ended. Cannot add more points to Player1.");
            }
            return ;
        }
        else
        {
            Player1Score++;
        }
    }

    public void AddPointPlayer2()
    {
        if ((Player1Score - Player2Score >= 2) && Player2Score >= 2)  // So it does not add points if the game has ended
        {
            if (VerboseFlag)
            {
                Console.WriteLine("Warning: The game has already ended. Cannot add more points to Player2.");
            }
            return ;
        }
        else
        {
            Player2Score++;            
        }
    }

    public string EncodeScore(int PlayerScore)
    {
        switch (PlayerScore)
        {
            case 0:
                return "Love";
            case 1:
                return "15";
            case 2:
                return "30";
            case 3:
                return "40";
            default:
                return "Invalid Score";  
        }
    }

    private int PlayerInFront(int Player1Score, int Player2Score)
    {
        if (Player1Score - Player2Score > 0)
            return 1;
        
        else if (Player1Score - Player2Score < 0)
            return 2;
        
        else 
            return 0;
    }

    private int ScoreDifference(int Player1Score, int Player2Score)
    {
        return Math.Abs(Player1Score - Player2Score);
    }

    public string ScoreMessage()
    {
        return ScoreMessage(Player1Score, Player2Score);
    }

    public string ScoreMessage(int Player1Score, int Player2Score)
    {   
        int LeadingPlayer = PlayerInFront(Player1Score, Player2Score);
        
        if (LeadingPlayer != 0)
        {
            int Diff = ScoreDifference(Player1Score, Player2Score);

            if ((Diff >= 2 && Diff <= 4 && Player1Score >= 4) || (Diff >= 2 && Diff <= 4 &&  Player2Score >= 4))
            {
                return $"Player{LeadingPlayer} wins!";
            }
            else if ((Diff > 3 && Player1Score > 4) || (Diff > 3 && Player2Score > 4))
            {
                return $"Invalid Scores: {Player1Score} - {Player2Score} -> {EncodeScore(Player1Score)} - {EncodeScore(Player2Score)}";
            }
            else if ((Diff >= 1 && Player1Score >= 4) || (Diff >= 1 && Player2Score >= 4))
            {
                return $"Player{LeadingPlayer} has the advantage";
            }
            else
            {
                return $"Player{LeadingPlayer} is {Diff} point(s) ahead, Score: {EncodeScore(Player1Score)} - {EncodeScore(Player2Score)}";
            }
        }
        else
        {
            if (Player1Score >= 3)
            {
                return "Deuce";
            }
            else
            {
                return $"{EncodeScore(Player1Score)} All";
            }
        }
    }
}