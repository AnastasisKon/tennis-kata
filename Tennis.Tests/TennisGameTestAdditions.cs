using Tennis;

namespace Tennis.Tests;

public class TennisGameTestProggressOfGames
{
    [Fact]
    public void Player1_wins_one_point()
    {
        // Arrange
        TennisGame game = new TennisGame();

        // Act
        game.AddPointPlayer1();

        // Assert
        string result = game.ScoreMessage(1, 0);

        Assert.Equal("15 - Love", result);
    }
}