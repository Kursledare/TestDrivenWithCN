using System;
using MartialArtsLegends;
using NUnit.Framework;
using Tests.Dummies;

namespace Tests
{
    [TestFixture]
    public class ChuckNorrisTests
    {
        [Test]
        public void CanKickToReduce10HitPoints()
        {
            const Int32 originalHitPoints = 10;
            const Int32 expectedHitPoints = 0;

            ITarget target = new CrashTestDummy(originalHitPoints);
            IKicks chuck = new ChuckNorris();
            chuck.RoundhouseKick(target);

            Assert.That(target.HitPoints, Is.LessThan(originalHitPoints));
            Assert.That(target.HitPoints, Is.EqualTo(expectedHitPoints));
        }
    }
}