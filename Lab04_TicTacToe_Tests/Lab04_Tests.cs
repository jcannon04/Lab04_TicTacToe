using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe.Tests
{
    public class BoardTests
    {
        public static IEnumerable<object[]> WinningBoards()
        {
            yield return new object[] { new string[,]
            {
                {"X", "2", "3"},
                {"X", "5", "6"},
                {"X", "8", "9"},
            } };

            yield return new object[] { new string[,]
            {
                {"1", "X", "3"},
                {"4", "X", "6"},
                {"7", "X", "9"},
            } };

        }

        public static IEnumerable<object[]> NonWinningBoards()
        {
            yield return new object[] { new string[,]
            {
                {"X", "2", "3"},
                {"4", "O", "6"},
                {"7", "8", "9"},
            } };

            yield return new object[] { new string[,]
            {
                {"1", "2", "X"},
                {"4", "5", "O"},
                {"X", "8", "9"},
            } };

        }

        [Theory]
        [MemberData(nameof(WinningBoards))]
        public void CheckForWinner_ShouldReturnTrue_WhenWinningConditionMet(string[,] gameBoard)
        {
            // Arrange
            Player p1 = new Player();
            Player p2 = new Player();
            Board board = new Board();
            board.GameBoard = gameBoard;
            Game game = new Game(p1, p2);

            // Act
            bool result = game.CheckForWinner(board);

            // Assert
            Assert.True(result);
        }

        [Theory]
        [MemberData(nameof(NonWinningBoards))]
        public void CheckForWinner_ShouldReturnFalse_WhenNoWinningConditionMet(string[,] gameBoard)
        {
            // Arrange
            Player p1 = new Player();
            Player p2 = new Player();
            Board board = new Board();
            board.GameBoard = gameBoard;
            Game game = new Game(p1, p2);

            // Act
            bool result = game.CheckForWinner(board);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void SwitchPlayer_ShouldSwitchBetweenPlayers()
        {
            // Arrange
            Player p1 = new Player
            {
                Name = "p1",
                IsTurn = true
            };
            Player p2 = new Player
            {
                Name = "p2",
                IsTurn = false
            };
            Game game = new Game(p1, p2);

            // Act
            game.SwitchPlayer();
            Player currentPlayerAfterFirstSwitch = game.NextPlayer();

            game.SwitchPlayer();
            Player currentPlayerAfterSecondSwitch = game.NextPlayer();

            // Assert
            Assert.Equal(p2.Name, currentPlayerAfterFirstSwitch.Name);
            Assert.Equal(p1.Name, currentPlayerAfterSecondSwitch.Name);
        }

        [Theory]
        [InlineData(1, 0, 0)]
        [InlineData(2, 0, 1)]
        [InlineData(3, 0, 2)]
        [InlineData(4, 1, 0)]
        [InlineData(5, 1, 1)]
        [InlineData(6, 1, 2)]
        [InlineData(7, 2, 0)]
        [InlineData(8, 2, 1)]
        [InlineData(9, 2, 2)]
        public void GetPosition_ShouldReturnCorrectPosition(int input, int expectedRow, int expectedColumn)
        {

            Position position = Player.PositionForNumber(input);


            // Assert
            Assert.Equal(expectedRow, position.Row);
            Assert.Equal(expectedColumn, position.Column);
        }

    }
}
