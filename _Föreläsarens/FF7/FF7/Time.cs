using System;
using System.Collections.Generic;
using System.Text;

namespace FF7
{
    struct Time
    {
        public int Hours, Minutes, Seconds;

        public Time(int h, int m, int s)
        {
            Hours = h;
            Minutes = m;
            Seconds = s;
        }

        public int TotalSeconds() => Seconds + Minutes * 60 + Hours * 60 * 60;
    }
}
