using System;
using Xunit;
using MiniMax;

namespace Tests
{
    public class PlayerTest
    {
        [Theory]
        [InlineData("1,2", 0, 1, "X")]
        [InlineData("2,1", 1, 0, "X")]
        [InlineData("1,3", 0, 2, "X")]
        public void ShouldReturnConvertedCoordinateWhenValidUserInputIsInserted(string move, int x, int y, string symbol)
        {
            var coordinate = new Coordinates(x, y, symbol);
            var player = new Player("X", 1);       
            Assert.Equal(coordinate.GetRow(), player.FakeMove(move).GetRow());
            Assert.Equal(coordinate.GetCol(), player.FakeMove(move).GetCol());
            Assert.Equal(coordinate.GetSymbol(), player.FakeMove(move).GetSymbol());
        }
        
        [Theory]
        [InlineData("14,12", "That coordinate is invalid.")]
        [InlineData("12,2", "That coordinate is invalid.")]
        [InlineData("1,4", "That coordinate is invalid.")]
        public void ShouldThrowExceptionWhenInvalidUserInputIsInserted(string move, string expectedOutput)
        {
            var player = new Player("X", 1);
            Assert.Equal(expectedOutput, ex.Message);
        }
        
        [Theory]
        [InlineData("1,2")]
        [InlineData("2,1")]
        [InlineData("1,3")]
        public void ShouldReturnTrueWhenValidUserInputIsInserted(string move)
        {
            var player = new Player("X", 1);
            Assert.True(player.CheckIfValidMove(move));
        }
        
        [Theory]
        [InlineData("4,3")]
        [InlineData("12,16")]
        [InlineData("-1,2")]
        public void ShouldReturnFalseWhenInvalidUserInputIsInserted(string move)
        {
            var player = new Player("X", 1);
            Assert.False(player.CheckIfValidMove(move));
        }   
    }
}