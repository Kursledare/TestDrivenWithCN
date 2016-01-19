using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartialArtsLegends
{
    public class ChuckNorris : IKicks
    {
        public void RounhouseKick(ITarget target)
        {
            target.ReduceHitPoints(10);
        }
    }
}
