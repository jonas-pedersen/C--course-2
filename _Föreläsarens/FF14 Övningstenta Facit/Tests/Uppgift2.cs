using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class Uppgift2
    {
        abstract class Animal {}

        class Cat : Animal
        {
            public void Meow() => Console.WriteLine("Meow");
        }

        class Dog : Animal
        {
            public void Bark() => Console.WriteLine("Bark");
        }

        [TestMethod]
        public void Uppg()
        {
            // (5p)

            // T�nk dig att du har ovanst�ende klasser.

            // Du kan g�ra f�ljande:
            Cat c = new Cat();
            c.Meow();
            Dog d = new Dog();
            d.Bark();

            // a) Varf�r fungerar inte detta? Svara kortfattat i en kommentar.
            //List<Cat> djur = new List<Cat>();
            //djur.Add(c);
            //djur.Add(d);

            // b) Vilka *tv�* alternativ har du f�r att byta den generiska typen f�r List till 
            // ovan f�r att fixa det? Vad �r det f�r skillnad?

            /*
            a) d �r av typen Dog, dvs inte Cat, som ju listan ska inneh�lla. 
            �ven om de �rver fr�n samma basklass s� hj�lper inte det.

            b) 
            List<Animal> - d� f�r vi bara l�gga till Cat och Dog objekt (och ev andra klasser i framtiden
            som ocks� �rver fr�n Animal).
            List<object> - d� kan vi ocks� g�ra som ovanst�ende MEN vi kan ocks� l�gga till precis vad som helst,
            dvs en int, eller string, eller ...
            List<dynamic> 

            dynamic a = new Random();
            dynamic b = 3;
            dynamic c = a + b;

            */
        }
    }
}
