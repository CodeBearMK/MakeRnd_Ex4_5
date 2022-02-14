using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeRnd_Ex4_5
{
    internal class MakeRnd
    {
        public void GetRnd(int[] rng, int min, int max, int num)
        {
            Random rnd = new Random();
            for (int i = 0; i <= num; i++)
            {
                int rndnum;
                rndnum = rnd.Next(min, max + 1);
                while (rng.Contains(rndnum) == true)
                {
                    rndnum = rnd.Next(min, max);
                }
                rng[i] = rndnum;
            }
        }
    }
}
