using System;
using Xunit;
using MiniMax;

namespace Tests
{
    public class CoordinatesTest
    {
        private int _rowPos = 1;
        private int _colPos = 2;
        private string _symbol = "X";
        
        [Fact]
        public void Test1()
        {
            var coordinatesOne = new Coordinates(_rowPos, _colPos, _symbol);
            
            Assert.Equal(1, coordinatesOne.GetRow());
            Assert.Equal(2, coordinatesOne.GetCol());
            Assert.Equal("X", coordinatesOne.GetSymbol());
        }

        [Fact]
        public void Test2()
        {
            _rowPos = 12;
            _colPos = 533;
            _symbol = "This is a symbol";
            var coordinatesTwo = new Coordinates(12, 533, "This is a symbol");
            
            
            Assert.Equal(12, coordinatesTwo.GetRow());
            Assert.Equal(533, coordinatesTwo.GetCol());
            Assert.Equal("This is a symbol", coordinatesTwo.GetSymbol());
        }
    }
}