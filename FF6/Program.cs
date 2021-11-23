using System;

namespace FF6
{
    class Program
    {
        // Måste returnera något för att värdet ska ändras utanför funktionen
        // Detta då det kommer in ett värde (tex siffran 10) och den modifieras bara inom 
        // metoden. 
        static int IncreaseByFiveReturn(int i)
        {
            i += 5;
            return i;
        }

        // Andra alternativ om man inte vill returnera något -ref
        static void IncreaseByFiveRef(ref int i)
        {
            i += 5;
        }

        // Tredje alternativ med -out
        static void IncreaseByFiveOut(out int i)
        {
            i = 5;
        }

        // Denna metod får in en minnesadress och ändrar på det som ligger i den adressen.
        // Därför ändras värdet på p.X även fast den inte returnerar något
        static void IncreaseXByFive(Punkt q)
        {
            q.X += 5;
        }


        static void SetFirstNumberTo100(int[] a)
        {
            a[0] = 100;
        }


        //---Ber användaren skriva in två tal och returnerar då en ny Punkt---
        static Punkt GetNewPoint()
        {
            try
            {
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());

                return new Punkt(x, y);
            }
            catch (FormatException)
            {

                return null;
            }

        }

        //---Nullable Types exempel---
        static int? GetNumber()
        {
            try
            {
                Console.WriteLine("Enter a number:");
                int x = int.Parse(Console.ReadLine());

                return x;
            }
            catch (FormatException)
            {

                return null;
            }
        }


        /*        // Exempel på när bool? är bra att returnera.
                static bool? isItRaining()
                {
                    try
                    {
                        // Någon smart logik som läser av en sensor

                        return true; // eller false
                    }
                    // Vid nätverksfel tex...
                    catch (NetPipeStyleUriParser)
                    {
                        return null;
                    }
                }*/


        // -Eget Exempel för att lära sig att man inte behöver returnera en array ifrån en metod-
        static void ChangeFirstString(string[] sArr)
        {
            sArr[0] = "Hej på dig snygging!";
        }



        // ----MAIN----
        static void Main(string[] args)
        {

            // ---Exempel med skillnader mellan Värdetyper och Referenstyper---
            //// ---Värdetyper (value types)---
            //// Samma med float, double, long, bool, etc.
            //// Gör kopior av värden
            //int x = 10;
            //int y = x;
            //int z = y;
            //x = 20;
            //Console.WriteLine(y);

            //// ---Referenstyper (reference types)--- 
            //// Alla "mer" komplicerade objekt, arrayer, alla våra egna klasser, etc
            //// Dessa pekar på en adress i minnet. Så när man säger att q = p nedan så blir det 
            //// att denna adressen kopieras, dvs bägge pekar på samma adress. Mao blir q = p bara 
            //// att det är två olika namn på samma objekt. String är en referenstyp, men fungerar
            //// ungefär som värdetyper. 

            //Punkt p = new Punkt(2, 3);
            //Punkt q = p;

            //p.X = 80;
            //Console.WriteLine(q.X);



            //---Exempel Return vs ref vs out---
            // Klassiskt vis med return
            int y2 = 300;
            y2 = IncreaseByFiveReturn(y2);
            Console.WriteLine(y2);

            // Nytt sätt med referens. Här behöver vi inte sätta att x2 = IncreaseByFiveRef() 
            // då den ändrar på värdet som x2 refererar till (Ändrar på värdet x2).
            int x2 = 100;
            IncreaseByFiveRef(ref x2);
            Console.WriteLine(x2);

            // Två varianter med out
            int y;
            IncreaseByFiveOut(out y);
            Console.WriteLine("Med out " + y);

            //IncreaseByFiveOut(out int y3);
            //Console.WriteLine(y3);



            // ---Exempel för att visa hur det kan vara bra att sätta ett Objekt till null för att sedan
            // ge det en referens---
            //Punkt a = new Punkt(1, 2);
            //Punkt b = new Punkt(3, 4);
            //Punkt c = new Punkt(5, 6);

            //Punkt bästaPunkten = null;

            //// Någon smart sätt för att bestämma vilken som är bästa punkten....
            //// Sedan kan man använda nedan för att då låta bästaPunkten peka på den som är "den bästa"
            //if (true)
            //{
            //    bästaPunkten = a;
            //}
            //else
            //{
            //    bästaPunkten = b;
            //}



            // ---Exempel Nullable Types---
            //// Inte tillätet!
            //// int i = null;
            //// Om jag däremot vill det så får jag göra som följer:
            //int? i = GetNumber();

            //if (i == null)
            //{
            //    Console.WriteLine("Inget tal: ");
            //}
            //else
            //{
            //    Console.WriteLine(i);
            //}



            // ---Exempel -Får ej göras som nedan då den inte är deklarerad---
            //int j;
            //Console.WriteLine(j);



            //---Exempel -Null-conditional operator example---
            //Punkt p4 = GetNewPoint();
            //// Null check operator
            //Console.WriteLine(p4?.X);
            //Console.WriteLine($"X-värdet är {p4?.X + 12} och Y-värdet är {p4?.Y}");

            //if (p4 != null)
            //{
            //    Console.WriteLine($"{p4.X}, {p4.Y}");
            //}
            //else
            //{
            //    Console.WriteLine("Nu blev det tokigt!");
            //}



            // ---Exempel Ändrar på variabel/Objekts värden---

            //// Med value types
            //int i1 = 0;
            //i1 = 3;
            //i1 = 5;

            // Samma som ovan fast med objekt. 
            //Punkt p0 = null;
            //p0 = new Punkt(7, 9);
            //// Byter ut adressen till p0 till en ny punkt. 
            //p0 = new Punkt(10, 11);
            //Console.WriteLine(p0.X);    // Ger 10

            //Punkt p1 = null;
            //// Går ej att göra nedan då den är null!
            //// p1.X = 3;

            //Punkt q0 = p0.Copy();
            //Console.WriteLine(q0.X);       // Ger 10 också
            //q0.X = 15;
            //Console.WriteLine(q0.X);        // Ger 15 då metoden .Copy som vi gjort returnerar en new Punkt()



            //---Exempel -Strängar beter sig som referenstyper---
            //string s = "Det här är ju väldigt lång sträng";

            //// s[0] = 'C';   <--- Detta går inte då man inte kan ändra på en sträng. 
            //Console.WriteLine(s[0]);


            // ---Exempel -Måste returnera något om det är en sådan metod. Annars ändras inte x---
            //int x = 16;
            //// Här lägger vi bara in värdet i metoden nedan. x sätts inte till något returvärde sen. 
            //IncreaseByFiveReturn(x);
            //Console.WriteLine(x);


            // ---Exempel -Metoder som påverkar objekt behöver inte returnera något, det som sker i metoden
            // spparas i variabeln ändå (här p.X)
            //Punkt p = new Punkt(20, 20);
            //IncreaseXByFive(p);
            //Console.WriteLine(p.X);     //Ger 25


            // ---Exempel -Vår Copy-metod returnerar ny Punkt och därför är det olika punkter q, respektive q2
            //Punkt q = new Punkt(3, 5);
            //Punkt q2 = q.Copy();
            //Console.WriteLine(q.X);
            //Console.WriteLine(q2.X);
            //IncreaseXByFive(q2);
            //Console.WriteLine(q2.X);

            Punkt p = new Punkt(6, 9);

            // Båda sätt nedan kopierar punkten p's koordinater
            Punkt p2 = new Punkt(p.X, p.Y);
            Punkt p3 = p.Copy();

            // Visar att båda är samma genom att skriva ut de
            Console.WriteLine(p3.X);
            Console.WriteLine(p2.X);



            // ---Exempel hur man använder Array.Copy---
            int[] arr = new int[] { 2, 6, 4 };
            //int[] arr2 = new int[3];
            //Array.Copy(arr, arr2, 3);   
            //Console.WriteLine(arr2[1]);

            SetFirstNumberTo100(arr);
            Console.WriteLine(arr[0]);

            // --Testar lite ang arrayer och att man inte behöver returnera de ifrån metoden
            // för att ändringen ska "sparas"
            string[] arrString = new string[] { "Jonas", "Ellen", "Mamma" };
            Console.WriteLine(arrString[0]);
            ChangeFirstString(arrString);
            Console.WriteLine(arrString[0]);


        }
    }
}
