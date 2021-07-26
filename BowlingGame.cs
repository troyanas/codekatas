using System.Linq;
using NUnit.Framework;

namespace Katas.Tasks
{
    public class BowlingGameTests
    {
        [Test]
        public void TestCountScore()
        {
            var bowling = new BowlingGame();
            Assert.AreEqual(8, bowling.GetScore(new[] { new [] { 8, 0 } }));
        }

        [Test]
        public void TestCountScore2()
        {
            var bowling = new BowlingGame();
            Assert.AreEqual(30, bowling.GetScore(new[] { new [] { 10, 0 }, new[] { 10, 0 } }));
        }

        [Test]
        public void TestCountScore3()
        {
            var bowling = new BowlingGame();
            Assert.AreEqual(30, bowling.GetScore(new[] { new[] { 5, 5 }, new[] { 10, 0 } }));
        }


        [Test]
        public void TestCountScore4()
        {
            var bowling = new BowlingGame();
            Assert.AreEqual(20, bowling.GetScore(new[] { new[] { 0, 10 }, new[] { 0, 10 } }));
        }

        [Test]
        public void TestCountScore5()
        {
            var bowling = new BowlingGame();
            Assert.AreEqual(20, bowling.GetScore(new[] { new[] { 0, 10 }, new[] { 0, 10 } }));
        }

        [Test]
        public void TestCountScore6()
        {
            var bowling = new BowlingGame();
            Assert.AreEqual(45, bowling.GetScore(new[] { new[] { 2, 8 }, new[] { 2, 1 }, new[] { 10, 0 }, new[] { 5, 5 } }));
        }
    }

    public class BowlingGame
    {
        private const int max = 10;


        public int GetScore(int[][] points)
        {
            int[] prevNumber = new int[2];
            return points.SelectMany(a =>
            {
                int v = 0;
                if (prevNumber[0] > 9)
                {
                    v = a.Sum() * 2;
                }
                else if (prevNumber.Sum() > 9)
                {
                    v = a[0] * 2 + a[1];
                }
                else
                {
                    v = a.Sum();
                }
                prevNumber = a;
                return new int[]{ v };
            }).Sum();
        }
    }
}
