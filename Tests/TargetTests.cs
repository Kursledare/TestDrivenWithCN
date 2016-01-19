using System;
using MartialArtsLegends;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class TargetTests
    {
        [Test]
        public void HitPointsCannotFallBelowZero()
        {
            const Int32 originalHitPoints = 10;
            const Int32 damage = 20;
            const Int32 expectedHitPoints = 0;

            ITarget target = new RealTarget(originalHitPoints);
            target.ReduceHitPoints(damage);

            Assert.That(target.HitPoints, Is.Not.LessThan(expectedHitPoints));
        }

        [Test]
        public void HitPointsCanBeReducedCorrectly()
        {
            const Int32 originalHitpoints = 10;
            const Int32 damage = 5;
            const Int32 expectedHitPoints = originalHitpoints - damage;

            ITarget target = new RealTarget(originalHitpoints);
            target.ReduceHitPoints(damage);

            Assert.That(target.HitPoints, Is.EqualTo(expectedHitPoints));
        }

        [Test]
        public void IsInitializedCorrectly()
        {
            const Int32 originalHitpoints = 10;
            ITarget target = new RealTarget(originalHitpoints);

            Assert.That(target.HitPoints, Is.EqualTo(originalHitpoints));
        }
    }
}