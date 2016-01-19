using System;

namespace MartialArtsLegends
{
    public interface ITarget
    {
        Int32 HitPoints { get; }
        void ReduceHitPoints(Int32 hitPoints);
    }
}
