using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Roulette.Game
{
    public class Roulette
    {

        public static int Spin()
        {

            Random rand = new Random();

            int bin = rand.Next(0, 37);

            return bin;
        }
    }

    }


