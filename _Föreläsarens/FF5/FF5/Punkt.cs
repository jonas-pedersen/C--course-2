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


        public int X 
        { 
            get
            {
                // Lägg in vilken kod som helst
                Console.WriteLine("Nu läser någon variabeln X");

                return x;
            }
            set
            {
                Console.WriteLine($"Värdet på X ändras från {x} till {value}");

                x = value;
                distance = Math.Sqrt(x * x + y * y);
            }
        }  // property, men beter sig precis som variabler :)
        public int Y 
        { 
            get => y; 
            set => y = value; 
        }

        public Punkt(int xy)  // Alternativ konstruktor
        {
            X = xy;
            Y = xy;
        }

        public Punkt(int x, int y)  // Konstruktor
        {
            X = x;
            Y = y;
        }

        public double DistanceToCenter()
        {
            return distance;
        }

        public static double CenterDistance(Punkt p)
        {
            // ...
            // ...
            // ...
            // ...
            // ...
            // ...
            // ...
            // ...
            // ...
            // ...
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
