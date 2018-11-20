using Xunit;
using MiniMax;

namespace Tests
{
    public class GridTest
    {

        [Fact]
        public void TestGridForCoordinateCheck()
        {
            
            var validCoordinate = new Coordinates(1, 2, "X");
            var invalidCoordinate = new Coordinates(12, 13, "I'm not a single character");
            var grid = new Grid(3, 3);
            
            Assert.True(grid.CoordinateCheck(validCoordinate));
            Assert.False(grid.CoordinateCheck(invalidCoordinate));
            
        }

        [Fact]
        public void TestGridForPlacingTile()
        {
            var validCoordinate = new Coordinates(1, 2, "X");
            var invalidCoordinate = new Coordinates(12, 13, "I'm not a single character");
            var grid = new Grid(3, 3);
            
            Assert.True(grid.PlaceTile(validCoordinate));
            Assert.False(grid.PlaceTile(invalidCoordinate));
        }

    }
}