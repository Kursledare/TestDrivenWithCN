namespace MartialArtsLegends
{
    public class ChuckNorris : IKicks
    {
        public void RoundhouseKick(ITarget target)
        {
            target.ReduceHitPoints(10);
        }
    }
}