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

            // Tänk dig att du har ovanstående klasser.

            // Du kan göra följande:
            Cat c = new Cat();
            c.Meow();
            Dog d = new Dog();
            d.Bark();

            // a) Varför fungerar inte detta? Svara kortfattat i en kommentar.
            //List<Cat> djur = new List<Cat>();
            //djur.Add(c);
            //djur.Add(d);

            // b) Vilka *två* alternativ har du för att byta den generiska typen för List till 
            // ovan för att fixa det? Vad är det för skillnad?

            /*
            a) d är av typen Dog, dvs inte Cat, som ju listan ska innehålla. 
            Även om de ärver från samma basklass så hjälper inte det.

            b) 
            List<Animal> - då får vi bara lägga till Cat och Dog objekt (och ev andra klasser i framtiden
            som också ärver från Animal).
            List<object> - då kan vi också göra som ovanstående MEN vi kan också lägga till precis vad som helst,
            dvs en int, eller string, eller ...
            List<dynamic> 

            dynamic a = new Random();
            dynamic b = 3;
            dynamic c = a + b;

            */
        }
    }
}
