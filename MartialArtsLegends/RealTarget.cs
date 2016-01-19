using System;

namespace MartialArtsLegends
{
    public class RealTarget : ITarget
    {
        public RealTarget(Int32 originalHitPoints)
        {
            HitPoints = originalHitPoints;
        }

        public Int32 HitPoints { get; private set; }

        public void ReduceHitPoints(Int32 hitPoints)
        {
            HitPoints = Math.Max(0, HitPoints - hitPoints);
        }
    }
}