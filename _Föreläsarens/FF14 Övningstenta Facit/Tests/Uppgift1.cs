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
            // f�ljande collections har:
            // Array, List, Queue, HashSet

            /*
            Array och List �r snarlika i sitt utf�rande men List kan automatiskt ut�ka sin kapacitet vid behov.
            Medan Array �r en fix storlek med oftast h�gre prestanda.

            Queue erbjuder inte samma flexibilitet f�r att komma �t varje element,
            men �r mycket snabbare f�r att l�sa och ta bort det f�rsta elementet i k�n.

            HashSet �r v�ldigt snabb f�r att kolla upp om n�got ing�r i den,
            men kan inte ordna data s�som t.ex. en lista eller inneh�lla dubletter.
            */
        }
    }
}
