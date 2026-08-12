using System.Collections;
using System.Reflection.Emit;

namespace Tennis;

public class TennisGame
{
    int Player1Score = 0;
    int Player2Score = 0;

    public void AddPointPlayer1()
    {
        if (Player2Score == 4 && Player2Score != Player1Score)
        {
            Player2Score--;
        }
        else
        {
            Player1Score++;
        }
    }

    public void AddPointPlayer2()
    {
        if (Player1Score == 4 && Player2Score != Player1Score)
        {
            Player1Score--;
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
            case 4:
                return "Adv.";
            default:
                return "Unknown";  
        }
    }

    public int PlayerInFront(int Player1Score, int Player2Score)
    {
        if (Player1Score - Player2Score > 0)
            return 1;
        
        else if (Player1Score - Player2Score < 0)
            return 2;
        
        else 
            return 0;
    }

    public int ScoreDifference(int Player1Score, int Player2Score)
    {
        return Math.Abs(Player1Score - Player2Score);
    }

    public string ScoreMessage(int Player1Score, int Player2Score)
    {   
        if (PlayerInFront(Player1Score, Player2Score) != 0)
        {
            if (ScoreDifference(Player1Score, Player2Score) >= 2 && (Player1Score >= 2 || Player2Score >= 2))
            {
                return "Player" + PlayerInFront(Player1Score, Player2Score) + " wins!";
            }
            else
            {
                return "Player" + PlayerInFront(Player1Score, Player2Score) + " is " + ScoreDifference(Player1Score, Player2Score) + " point(s) ahead, Score: " + EncodeScore(Player1Score) + " - " + EncodeScore(Player2Score);
            }
        }
       else
        {
            if (Player1Score == 3)
            {
                return "Deuce";
            }
            else
            {
                return EncodeScore(Player1Score) + " All";
            }
        }
    }
}