using System;
using Xunit;
using PongPongClasses;

namespace PingPongUnitTests
{
    public class TicTacToeTests
    {
        [Fact]
        public void CanCreateTicTacToeClass()
        {
            var TicTacToe = new TicTacToe();

            Assert.NotNull(TicTacToe);
        }

        [Fact]
        public void TicTacToe_CanPlayMove_GivenCharacterAndLocation()
        {
            var TicTacToe = new TicTacToe();

            TicTacToe.Play('x', 1);
        }
    }
}
