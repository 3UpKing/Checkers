using System;

namespace checkers.test
{
    using NUnit.Framework;
    using System.Linq;    

    [TestFixture]
    public class Test
    {
        [Test]
        public void ABoardHas12BlackAnd12WhitePieces()
        {
            Board b = new Board();
            int blackCount = b.Pieces(Color.Black).Count();
            int whiteCount = b.Pieces(Color.White).Count();
            Assert.That(blackCount == 12);
            Assert.That(whiteCount == 12);
        }
    }
}
