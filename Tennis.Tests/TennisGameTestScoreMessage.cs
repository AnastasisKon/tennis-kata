using Tennis;

namespace Tennis.Tests;

public class TennisGameTestScoreMessage
{
    [Theory]
    [InlineData(0, 0, "Love All")]
    [InlineData(1, 1, "15 All")]
    [InlineData(2, 2, "30 All")]
    [InlineData(3, 3, "Deuce")]
    [InlineData(4, 4, "Deuce")]
    [InlineData(100000000, 5, "Invalid Scores: 100000000 - 5 -> Invalid Score - Invalid Score")]
    [InlineData(15, 30, "Invalid Scores: 15 - 30 -> Invalid Score - Invalid Score")]
    [InlineData(15, 15, "Deuce")]
    [InlineData(30, 30, "Deuce")]
    [InlineData(40, 40, "Deuce")]
    [InlineData(40, 15, "Invalid Scores: 40 - 15 -> Invalid Score - Invalid Score")]
    [InlineData(5, 5, "Deuce")]
    [InlineData(6, 5, "Player1 has the advantage")]
    [InlineData(5, 6, "Player2 has the advantage")]
    [InlineData(5, 7, "Player2 wins!")]
    [InlineData(5, 8, "Invalid Scores: 5 - 8 -> Invalid Score - Invalid Score")]
    [InlineData(5, 9, "Invalid Scores: 5 - 9 -> Invalid Score - Invalid Score")]
    [InlineData(5, 10, "Invalid Scores: 5 - 10 -> Invalid Score - Invalid Score")]


    public void GameScores(int score1, int score2, string expected)
    {
        TennisGame game = new TennisGame();
        string result = game.ScoreMessage(score1, score2);
        Assert.Equal(expected, result);
    }
}

