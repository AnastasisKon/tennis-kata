using Tennis;

namespace Tennis.Tests;

public class TennisGameTestScore
{
    [Theory]
    [InlineData(0, "Love")]
    [InlineData(1, "15")]
    [InlineData(2, "30")]
    [InlineData(3, "40")]
    public void ScoreIsEncodedCorrectly(int score, string expected)
    {
        TennisGame game = new TennisGame();

        string result = game.EncodeScore(score);

        Assert.Equal(expected, result);
    }
}