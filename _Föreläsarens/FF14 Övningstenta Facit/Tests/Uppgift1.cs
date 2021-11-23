using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class Uppgift1
    {
        [TestMethod]
        public void Uppg()
        {
            // (5p)

            // Beskriv i en kommentar kortfattat vilka styrkor och nackdelar
            // följande collections har:
            // Array, List, Queue, HashSet

            /*
            Array och List är snarlika i sitt utförande men List kan automatiskt utöka sin kapacitet vid behov.
            Medan Array är en fix storlek med oftast högre prestanda.

            Queue erbjuder inte samma flexibilitet för att komma åt varje element,
            men är mycket snabbare för att läsa och ta bort det första elementet i kön.

            HashSet är väldigt snabb för att kolla upp om något ingår i den,
            men kan inte ordna data såsom t.ex. en lista eller innehålla dubletter.
            */
        }
    }
}
