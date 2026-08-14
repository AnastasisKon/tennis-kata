using Tennis;

namespace Tennis.Tests;

public class TennisGameTestProggressOfGames
{
    [Fact]
    public void NewGameIsLoveAll()
    {
        // Arrange
        TennisGame game = new TennisGame();

        // Act
        // Empty game

        // Assert
        Assert.Equal("Love All", game.ScoreMessage());
    }

    [Fact]
    public void Player1Wins1Point()
    {
        // Arrange
        TennisGame game = new TennisGame();

        // Act
        game.AddPointPlayer1();

        // Assert
        string result1 = game.ScoreMessage();

        Assert.Equal("Player1 is 1 point(s) ahead, Score: 15 - Love", result1);
    }

    [Fact]
    public void Player1Wins2Point()
    {
        // Arrange
        TennisGame game = new TennisGame();

        // Act
        game.AddPointPlayer1();
        game.AddPointPlayer1();

        // Assert
        string result1 = game.ScoreMessage();

        Assert.Equal("Player1 is 2 point(s) ahead, Score: 30 - Love", result1);
    }

    [Fact]
    public void Player1Wins3Point()
    {
        // Arrange
        TennisGame game = new TennisGame();

        // Act
        game.AddPointPlayer1();
        game.AddPointPlayer1();
        game.AddPointPlayer1();

        // Assert
        string result1 = game.ScoreMessage();

        Assert.Equal("Player1 is 3 point(s) ahead, Score: 40 - Love", result1);
    }

    [Fact]
    public void Player1Wins4PointWIN()
    {
        // Arrange
        TennisGame game = new TennisGame();

        // Act
        game.AddPointPlayer1();
        game.AddPointPlayer1();
        game.AddPointPlayer1();
        game.AddPointPlayer1();

        // Assert
        string result1 = game.ScoreMessage();

        Assert.Equal("Player1 wins!", result1);
    }

    ////////////////////////////////////////////////////////////////////////

    [Fact]
    public void Player2Wins1Point()
    {
        // Arrange
        TennisGame game = new TennisGame();

        // Act
        game.AddPointPlayer2();

        // Assert
        string result1 = game.ScoreMessage();

        Assert.Equal("Player2 is 1 point(s) ahead, Score: Love - 15", result1);
    }

    [Fact]
    public void Player2Wins2Point()
    {
        // Arrange
        TennisGame game = new TennisGame();

        // Act
        game.AddPointPlayer2();
        game.AddPointPlayer2();

        // Assert
        string result1 = game.ScoreMessage();

        Assert.Equal("Player2 is 2 point(s) ahead, Score: Love - 30", result1);
    }

    [Fact]
    public void Player2Wins3Point()
    {
        // Arrange
        TennisGame game = new TennisGame();

        // Act
        game.AddPointPlayer2();
        game.AddPointPlayer2();
        game.AddPointPlayer2();

        // Assert
        string result1 = game.ScoreMessage();

        Assert.Equal("Player2 is 3 point(s) ahead, Score: Love - 40", result1);
    }

    [Fact]
    public void Player2Wins4PointWIN()
    {
        // Arrange
        TennisGame game = new TennisGame();

        // Act
        game.AddPointPlayer2();
        game.AddPointPlayer2();
        game.AddPointPlayer2();
        game.AddPointPlayer2();

        // Assert
        string result1 = game.ScoreMessage();

        Assert.Equal("Player2 wins!", result1);
    }

    /////////////////////////////////////////////////////////////////////////

    [Fact]
    public void Player1Wins1PointPlayer2Wins1Point()
    {
        // Arrange
        TennisGame game = new TennisGame();

        // Act
        game.AddPointPlayer2();
        game.AddPointPlayer1();

        // Assert
        string result1 = game.ScoreMessage();

        Assert.Equal("15 All", result1);
    }

    [Fact]
    public void Player1Wins2PointPlayer2Wins1Point()
    {
        // Arrange
        TennisGame game = new TennisGame();

        // Act
        game.AddPointPlayer1();
        game.AddPointPlayer1();
        game.AddPointPlayer2();

        // Assert
        string result1 = game.ScoreMessage();

        Assert.Equal("Player1 is 1 point(s) ahead, Score: 30 - 15", result1);
    }

    [Fact]
    public void Player1Wins3PointPlayer2Wins1Point()
    {
        // Arrange
        TennisGame game = new TennisGame();

        // Act
        game.AddPointPlayer1();
        game.AddPointPlayer1();
        game.AddPointPlayer1();
        game.AddPointPlayer2();

        // Assert
        string result1 = game.ScoreMessage();

        Assert.Equal("Player1 is 2 point(s) ahead, Score: 40 - 15", result1);
    }

    [Fact]
    public void Player1Wins4PointWINPlayer2Wins1Point()
    {
        // Arrange
        TennisGame game = new TennisGame();

        // Act
        game.AddPointPlayer1();
        game.AddPointPlayer1();
        game.AddPointPlayer1();
        game.AddPointPlayer2();
        game.AddPointPlayer1();


        // Assert
        string result1 = game.ScoreMessage();

        Assert.Equal("Player1 wins!", result1);
    }

    //////////////////////////////////////////////////////////////////////////

    [Fact]
    public void Player1Wins1PointPlayer2Wins2Point()
    {
        // Arrange
        TennisGame game = new TennisGame();

        // Act
        game.AddPointPlayer2();
        game.AddPointPlayer2();
        game.AddPointPlayer1();

        // Assert
        string result1 = game.ScoreMessage();

        Assert.Equal("Player2 is 1 point(s) ahead, Score: 15 - 30", result1);
    }

    [Fact]
    public void Player1Wins2PointPlayer2Wins2Point()
    {
        // Arrange
        TennisGame game = new TennisGame();

        // Act
        game.AddPointPlayer1();
        game.AddPointPlayer2();
        game.AddPointPlayer1();
        game.AddPointPlayer2();

        // Assert
        string result1 = game.ScoreMessage();

        Assert.Equal("30 All", result1);
    }

    [Fact]
    public void Player1Wins3PointPlayer2Wins2Point()
    {
        // Arrange
        TennisGame game = new TennisGame();

        // Act
        game.AddPointPlayer1();
        game.AddPointPlayer2();
        game.AddPointPlayer1();
        game.AddPointPlayer1();
        game.AddPointPlayer2();

        // Assert
        string result1 = game.ScoreMessage();

        Assert.Equal("Player1 is 1 point(s) ahead, Score: 40 - 30", result1);
    }

    [Fact]
    public void Player1Wins4PointWINPlayer2Wins2Point()
    {
        // Arrange
        TennisGame game = new TennisGame();

        // Act
        game.AddPointPlayer1();
        game.AddPointPlayer2();
        game.AddPointPlayer1();
        game.AddPointPlayer1();
        game.AddPointPlayer2();
        game.AddPointPlayer1();


        // Assert
        string result1 = game.ScoreMessage();

        Assert.Equal("Player1 wins!", result1);
    }
    /////////////////////////////////////////////////////////////////////////////
    
    [Fact]
    public void Player1Wins1PointPlayer2Wins3Point()
    {
        // Arrange
        TennisGame game = new TennisGame();

        // Act
        game.AddPointPlayer2();
        game.AddPointPlayer2();
        game.AddPointPlayer1();
        game.AddPointPlayer2();

        // Assert
        string result1 = game.ScoreMessage();

        Assert.Equal("Player2 is 2 point(s) ahead, Score: 15 - 40", result1);
    }

    [Fact]
    public void Player1Wins2PointPlayer2Wins3Point()
    {
        // Arrange
        TennisGame game = new TennisGame();

        // Act
        game.AddPointPlayer1();
        game.AddPointPlayer2();
        game.AddPointPlayer2();
        game.AddPointPlayer1();
        game.AddPointPlayer2();

        // Assert
        string result1 = game.ScoreMessage();

        Assert.Equal("Player2 is 1 point(s) ahead, Score: 30 - 40", result1);
    }

    [Fact]
    public void Player1Wins3PointPlayer2Wins3Point()
    {
        // Arrange
        TennisGame game = new TennisGame();

        // Act
        game.AddPointPlayer1();
        game.AddPointPlayer2();
        game.AddPointPlayer2();
        game.AddPointPlayer2();
        game.AddPointPlayer1();
        game.AddPointPlayer1();


        // Assert
        string result1 = game.ScoreMessage();

        Assert.Equal("Deuce", result1);
    }

    [Fact]
    public void Player1Wins4PointPlayer2Wins3Point()
    {
        // Arrange
        TennisGame game = new TennisGame();

        // Act
        game.AddPointPlayer1();
        game.AddPointPlayer2();
        game.AddPointPlayer2();
        game.AddPointPlayer1();
        game.AddPointPlayer1();
        game.AddPointPlayer2();
        game.AddPointPlayer1();


        // Assert
        string result1 = game.ScoreMessage();

        Assert.Equal("Player1 has the advantage", result1);
    }

    [Fact]
    public void Player1Wins4PointPlayer2Wins4Point()
    {
        // Arrange
        TennisGame game = new TennisGame();

        // Act
        game.AddPointPlayer1();
        game.AddPointPlayer2();
        game.AddPointPlayer2();
        game.AddPointPlayer1();
        game.AddPointPlayer1();
        game.AddPointPlayer2();
        game.AddPointPlayer1();
        game.AddPointPlayer2();


        // Assert
        string result1 = game.ScoreMessage();

        Assert.Equal("Deuce", result1);
    }

    [Fact]
    public void Player1Wins6PointWINPlayer2Wins4Point()
    {
        // Arrange
        TennisGame game = new TennisGame();

        // Act
        game.AddPointPlayer1();
        game.AddPointPlayer2();
        game.AddPointPlayer2();
        game.AddPointPlayer1();
        game.AddPointPlayer1();
        game.AddPointPlayer2();
        game.AddPointPlayer1();
        game.AddPointPlayer1();
        game.AddPointPlayer1();
        game.AddPointPlayer2();

        // Assert
        string result1 = game.ScoreMessage();

        Assert.Equal("Player1 wins!", result1);
    }

    [Fact]
    public void Player1Wins7PointWINPlayer2Wins4Point()
    {
        // Arrange
        TennisGame game = new TennisGame();

        // Act
        game.AddPointPlayer1();
        game.AddPointPlayer2();
        game.AddPointPlayer2();
        game.AddPointPlayer1();
        game.AddPointPlayer1();
        game.AddPointPlayer2();
        game.AddPointPlayer1();
        game.AddPointPlayer1();
        game.AddPointPlayer1();
        game.AddPointPlayer2();
        game.AddPointPlayer1();

        // Assert
        string result1 = game.ScoreMessage();

        Assert.Equal("Player1 wins!", result1);
    }

    [Fact]
    public void Player1Wins7PointWINPlayer2Wins5Point()
    {
        // Arrange
        TennisGame game = new TennisGame();

        // Act
        game.AddPointPlayer1();
        string result1 = game.ScoreMessage();
        Assert.Equal("Player1 is 1 point(s) ahead, Score: 15 - Love", result1);

        game.AddPointPlayer2();
        string result2 = game.ScoreMessage();
        Assert.Equal("15 All", result2);

        game.AddPointPlayer2();
        string result3 = game.ScoreMessage();
        Assert.Equal("Player2 is 1 point(s) ahead, Score: 15 - 30", result3);

        game.AddPointPlayer1();
        string result4 = game.ScoreMessage();
        Assert.Equal("30 All", result4);

        game.AddPointPlayer1();
        string result5 = game.ScoreMessage();
        Assert.Equal("Player1 is 1 point(s) ahead, Score: 40 - 30", result5);

        game.AddPointPlayer2();
        string result6 = game.ScoreMessage();
        Assert.Equal("Deuce", result6);

        game.AddPointPlayer1();
        string result7 = game.ScoreMessage();
        Assert.Equal("Player1 has the advantage", result7);

        game.AddPointPlayer2();
        string result8 = game.ScoreMessage();
        Assert.Equal("Deuce", result8);

        game.AddPointPlayer2();
        string result9 = game.ScoreMessage();
        Assert.Equal("Player2 has the advantage", result9);

        game.AddPointPlayer1();
        string result10 = game.ScoreMessage();
        Assert.Equal("Deuce", result10);

        game.AddPointPlayer2();
        string result11 = game.ScoreMessage();
        Assert.Equal("Player2 has the advantage", result11);

        game.AddPointPlayer2();
        string result12 = game.ScoreMessage();
        Assert.Equal("Player2 wins!", result12);

        game.AddPointPlayer1();
        game.AddPointPlayer1();
        string result13 = game.ScoreMessage();
        Assert.Equal("Player2 wins!", result13);

        game.AddPointPlayer2();
        string result = game.ScoreMessage();
        Assert.Equal("Player2 wins!", result);
    }
}

