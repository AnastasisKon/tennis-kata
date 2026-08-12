namespace Tennis;

public class TennisGame
{
    private int Player1Score = 0;
    private int Player2Score = 0;

    public void AddPointPlayer1()
    {
        if (Player2Score - Player1Score >= 2 && Player1Score >= 2)  // So it does not add points if the game has ended
            return ;
        else
            {
                Player1Score++;
            }
    }

    public void AddPointPlayer2()
    {
        if (Player1Score - Player2Score >= 2 && Player2Score >= 2)  // So it does not add points if the game has ended

            return ;
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
                return "Unknown";  
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
        int LeadingPlayer = PlayerInFront(Player1Score, Player2Score);
        if (LeadingPlayer != 0)
        {
            if ((ScoreDifference(Player1Score, Player2Score) >= 2 && Player1Score >= 4) || (ScoreDifference(Player1Score, Player2Score) >= 2 && Player2Score >= 4))
            {
                return $"Player{LeadingPlayer} wins!";
            }
            else if ((ScoreDifference(Player1Score, Player2Score) >= 1 && Player1Score >= 4) || (ScoreDifference(Player1Score, Player2Score) >= 1 && Player2Score >= 4))
            {
                return $"Player{LeadingPlayer} has the advantage";
            }
            else
            {
                return $"Player{LeadingPlayer} is {ScoreDifference(Player1Score, Player2Score)} point(s) ahead, Score: {EncodeScore(Player1Score)} - {EncodeScore(Player2Score)}";
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