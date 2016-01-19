using System;
using MartialArtsLegends;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class ChuckNorrisTests
    {
        public class CrashTestDummy : ITarget
        {
            public CrashTestDummy(Int32 hitPoints)
            {
                HitPoints = hitPoints;
            }

            public Int32 HitPoints { get; private set; }

            public void ReduceHitPoints(Int32 hitPoints)
            {
                HitPoints -= hitPoints;
            }
        }

        [Test]
        public void CanKickToReduce10HitPoints()
        {
            const Int32 originalHitpoints = 10;
            const Int32 expectedHitPoints = 0;

            ITarget target = new CrashTestDummy(originalHitpoints);
            IKicks chuck = new ChuckNorris();
            chuck.RounhouseKick(target);

            Assert.That(target.HitPoints, Is.LessThan(originalHitpoints));
            Assert.That(target.HitPoints, Is.EqualTo(expectedHitPoints));
        }
    }
}