using System;
using Xunit;
using MiniMax;

namespace Tests
{
    public class CoordinatesTest
    {
        
        [Theory]
        [InlineData(1, 2, "X")]
        [InlineData(5, 6, "O")]
        public void TestCoordinatesForNormalScenario(int rowPos, int colPos, string symbol)
        {
            var coordinatesOne = new Coordinates(rowPos, colPos, symbol);
            Assert.Equal(rowPos, coordinatesOne.GetRow());
            Assert.Equal(colPos, coordinatesOne.GetCol());
            Assert.Equal(symbol, coordinatesOne.GetSymbol());
        }

        [Theory]
        [InlineData(12, 533, "This is a symbol")]
        public void TestCoordinatesForRandomScenario(int rowPos, int colPos, string symbol)
        {
            var coordinatesTwo = new Coordinates(rowPos, colPos, symbol);
            Assert.Equal(rowPos, coordinatesTwo.GetRow());
            Assert.Equal(colPos, coordinatesTwo.GetCol());
            Assert.Equal(symbol, coordinatesTwo.GetSymbol());
        }

    }
}