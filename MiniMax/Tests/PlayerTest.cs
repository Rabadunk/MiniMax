using System;
using Xunit;
using MiniMax;

namespace Tests
{
    public class PlayerTest
    {

        private string _fakeMove;

        [Fact]
        public void TestPlayerMoveForValidMove()
        {
            var playerMove = new MiniMax.Player();
            _fakeMove  = "1,2";
            playerMove.SetMove(_fakeMove);  
            Assert.True(playerMove.IsValid());


            _fakeMove = "a;sdfk;slkj";
            playerMove.SetMove(_fakeMove);
            Assert.False(playerMove.IsValid());

            _fakeMove = "12,34";
            playerMove.SetMove(_fakeMove);
            Assert.True(playerMove.IsValid());

            _fakeMove = "a,b";
            playerMove.SetMove(_fakeMove);
            Assert.False(playerMove.IsValid());
            
            _fakeMove = "a,b,c";
            playerMove.SetMove(_fakeMove);
            Assert.False(playerMove.IsValid());
            
            _fakeMove = "1,2,3";
            playerMove.SetMove(_fakeMove);
            Assert.False(playerMove.IsValid());
        }

        [Fact]
        public void TestPlayerMoveForGetRowAndGetCol()
        {
            var playerMove = new MiniMax.Player();
            _fakeMove = "1,2";
            playerMove.SetMove(_fakeMove);
            Assert.Equal(1, playerMove.GetRowMove());
            Assert.Equal(2, playerMove.GetColMove());

            _fakeMove = "a,b";
            playerMove.SetMove(_fakeMove);
            Assert.Equal(1, playerMove.GetRowMove());
            Assert.Equal(2, playerMove.GetColMove());
            
            _fakeMove = "12,34";
            playerMove.SetMove(_fakeMove);
            Assert.Equal(12, playerMove.GetRowMove());
            Assert.Equal(34, playerMove.GetColMove());
        }

    }
}