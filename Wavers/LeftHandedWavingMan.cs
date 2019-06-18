using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wavers
{
    class LeftHandedWavingMan : WavingMan
    {
        public LeftHandedWavingMan(int x, int y) : base(x, y)
        {
        }

        protected override void WriteHead()
        {
            Console.WriteLine(_armIsUp ? " o/" : " o");
        }

        protected override void WriteBody()
        {
            Console.WriteLine(_armIsUp ? "/|" : "/|\\");
        }
    }
}
