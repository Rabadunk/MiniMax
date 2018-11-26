using Xunit;
using MiniMax;

namespace Tests
{
    public class GridTest
    {
        [Theory]
        [InlineData(1, 2, "X", 3)]
        public void TestGridForValidCoordinates(int rowPos, int colPos, string symbol, int size)
        {
            var validCoordinate = new Coordinates(rowPos, colPos, symbol);
            var grid = new Grid(size);
            Assert.True(grid.CoordinateCheck(validCoordinate));
        }
        
        [Theory]
        [InlineData(12, 13, "I'm not a single character", 3)]
        public void TestGridForInvalidCoordinates(int rowPos, int colPos, string symbol, int size)
        {
            var invalidCoordinate = new Coordinates(rowPos, colPos, symbol);
            var grid = new Grid(size);
            Assert.False(grid.CoordinateCheck(invalidCoordinate));
        }
        
        [Theory]
        [InlineData(1, 2, "X", 3)]
        public void TestGridForPlacingValidTile(int rowPos, int colPos, string symbol, int size)
        {
            var validCoordinate = new Coordinates(rowPos, colPos, symbol);
            var grid = new Grid(size);
            Assert.True(grid.PlaceTile(validCoordinate));
        }
        
        [Theory]
        [InlineData(12, 13, "I'm not a single character", 3)]
        public void TestGridForPlacingInvalidTile(int rowPos, int colPos, string symbol, int size)
        {
            var invalidCoordinate = new Coordinates(rowPos, colPos, symbol);
            var grid = new Grid(size);
            Assert.False(grid.PlaceTile(invalidCoordinate));
        }

        [Theory]
        [InlineData(1, 1, 1, 2, 1, 3)]
        public void ShouldReturnTrueWhenFullRowIsPresent(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            var coordinateOne = new Coordinates(x1, y1, "X");
            var coordinateTwo = new Coordinates(x2, y2, "X");
            var coordinateThree = new Coordinates(x3, y3, "X");
            var grid = new Grid(3);
            grid.PlaceTile(coordinateOne);
            grid.PlaceTile(coordinateTwo);
            grid.PlaceTile(coordinateThree);
            
            Assert.True(grid.CheckRowWinCondition());
        }

    }
}