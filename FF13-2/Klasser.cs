using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF13_2
{
    // Interface kan inte ha privata variabler
    // Kan inte ha logik i interfaces, men kan det i basklasser. 
    // Interface är mer som ett recept/mall för hur man vill ha klasserna. 
    // Man kan bara ärva ifrån en klass, men kan implementera flera interfaces. 


    interface IAccelererbar
    {
        public float Distans { get; set; }
        public void Accelerera();
    }

    class Fordon
    {
        // De andra som ärver kommer inte åt denna då den är privat för just Fordon.
        //private float Hastighet = 0;

        // Syns bara internt i denna klass OCH alla klasser som ärver.
        protected float Hastighet = 0;
        public float Distans { get; set; } = 0;

        protected string Info()
        {
            return $"Hastighet { Hastighet}, Total sträcka { Distans}";
            
        }

        public override string ToString()
        {
            return GetType().ToString() + "!" + Info();
        }
    }


    class Cykel: Fordon, IAccelererbar
    {
        //public float Distans { get; set; } = 0;

        

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
        //    return "Cykel!" + Info();
        //}
    }

    class Volvo: Fordon, IAccelererbar
    {
        //public float Distans { get; set; } = 0;

        //private float Hastighet = 0;

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
        //    return "Volvo!" + Info();
        //}
    }

    class Rymdraket : Fordon, IAccelererbar
    {
        //public float Distans { get; set; } = 0;

        //private float Hastighet = 0.01f;
        public void Accelerera()
        {
            Hastighet += 0.01f;
            Hastighet *= 2;
            Distans += Hastighet;
        }

        //public override string ToString()
        //{
        //    return "Rymdraket!" + Info();
        //}
    }

}
