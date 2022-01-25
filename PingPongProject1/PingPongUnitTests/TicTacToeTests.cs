using System;
using Xunit;
using PongPongClasses;

namespace PingPongUnitTests
{
    public class TicTacToeTests
    {
        private TicTacToe Game;

        public TicTacToeTests()
        {
            Game = new TicTacToe();
        }

        [Fact]
        public void CanCreateTicTacToeClass()
        {
            Assert.NotNull(Game);
        }

        [Fact]
        public void Play_GivenCharacterAndLocation_WillReturnTrue()
        {
            var success = Game.Play('x', 1);

            Assert.True(success);
        }

        [Fact]
        public void Play_GivenATakenLocation_WillReturnFalse()
        {
            Game.Play('x', 1);
            var result = Game.Play('x', 1);

            Assert.False(result);
        }
    }
}
