using System;
using MartialArtsLegends;

namespace Tests.Dummies
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
}