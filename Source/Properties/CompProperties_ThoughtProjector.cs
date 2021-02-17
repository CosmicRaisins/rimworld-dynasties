using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Verse;

namespace Shenzhou
{
    public class CompProperties_ThoughtProjector : CompProperties
    {
        public int radius = 1;
        public int tickInterval = 1000;
        public string thoughtDef = "AteWithoutTable";
        public bool showEffect = false;

        public CompProperties_ThoughtProjector()
        {
            this.compClass = typeof(CompThoughtProjector);
        }


    }
}
