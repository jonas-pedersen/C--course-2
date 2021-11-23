using System;
using System.Collections.Generic;
using System.Text;


namespace FF5
{
    class Cirkel
    {
        public float Radie;

        public Cirkel(float r)
        {
            Radie = r;
        }

        public float Area()
        {
            return (float)Math.PI * Radie * Radie;
        }

        public float Omkrets()
        {
            return (float)Math.PI * Radie * 2;
        }

    }
}