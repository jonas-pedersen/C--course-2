using System;
using System.Collections.Generic;
using System.Text;

namespace FF13_2
{
    interface IAccelererbar
    {
        public float Distans { get; set; }
        public void Accelerera();
    }

    class Fordon
    {
        public float Distans { get; set; } = 0;
        protected float Hastighet = 0;

        protected string Info()
        {
            return $"Hastighet {Hastighet}, Total sträcka {Distans}";
        }

        public override string ToString()
        {
            //string s = nameof();
        }
    }

    class Cykel: Fordon, IAccelererbar
    {
        public void Accelerera()
        {
            Hastighet += 0.5f;
            if (Hastighet > 3.0f)
            {
                Hastighet = 3.0f;
            }

            Distans += Hastighet;
        }

        //public override string ToString()
        //{
        //    return "Cykel! " + Info();
        //}
    }

    class Volvo : Fordon, IAccelererbar
    {
        public void Accelerera()
        {
            Hastighet += 0.7f;
            if (Hastighet > 10.0f)
            {
                Hastighet = 10.0f;
            }

            Distans += Hastighet;
        }

        //public override string ToString()
        //{
        //    return "Volvo! " + Info();
        //}
    }

    class Rymdraket : Fordon, IAccelererbar
    {
        public void Accelerera()
        {
            Hastighet += 0.01f;
            Hastighet *= 2;

            Distans += Hastighet;
        }

        //public override string ToString()
        //{
        //    return "Rymdraket! " + Info();
        //}
    }
}
