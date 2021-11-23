using System;
using System.Collections.Generic;
using System.Text;

namespace FF5
{
    class Punkt
    {

        private int x;
        private int y;
        private double distance;

        // Properties är som variabler fast med get och set metoderna. 
        public int X
        {
            get
            {
                // Här kan det ligga en massa kod som körs när property:n hämtas med get
                Console.WriteLine("Nu läser någon variabeln X");
                return x;
            }
            set
            {
                Console.WriteLine($"Värdet på X ändras från {x} till {value}");
                x = value;
                
                // Kan ha beräkningar här också
                //distance = Math.Sqrt(x * x + y * y);
            }
        }

        // Samma som ovan fast med pilnotation istället. 
        public int Y
        {
            get => y;
            set 
            {
                Console.WriteLine($"Y-sätts! till {value}");
                y = value; 
            }
        }



        //// Property. Ser ut som en variabel.
        //// Kan inte ändra på den utanför klassen, pga "private"
        //public int X { get;  private set; }
        //public int Y { get;  private set; }  

        // ----Konstruktor när man bara får in en parameter----
        public Punkt(int xy)
        {
            X = xy;
            Y = xy;
        }


        // ----Konstruktor vid 2 in-parametrar----
        public Punkt(int x, int y)
        {
            X = x;
            Y = y;
        }

        // --Gammalt sätt att definiera setter och getter--
        //public int GetX() => X;

        //public int SetX(int x)
        //{
        //    return X = x;
        //}


        //--Metoder--
        // Behöver vara public för att vi ska kunna använa metoden utanför klassen.
        // Gäller för ett specifikt objekt
        public double DistanceToCenter() => Math.Sqrt(X * X + Y * Y);
        

        // Denna är static och då måste vi p.X tex. Refererar inte till ett specifikt objekt.
        public static double CenterDistance(Punkt p)
        {
            return Math.Sqrt(p.X * p.X + p.Y * p.Y);
        }

        public static Punkt operator +(Punkt left, Punkt right) 
        {
            return new Punkt(left.X + right.X, left.Y + right.Y);
        }

        public static Punkt operator *(Punkt left, Punkt right)
        {
            return new Punkt(left.X * right.X, left.Y * right.Y);
        }
        public static Punkt operator *(Punkt left, int right)
        {
            return new Punkt(left.X * right, left.Y * right);
        }



    }
}
