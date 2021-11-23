using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading;

namespace FF8
{
    // Interface är inte en klass, men mer än beskrivning av vad som bör finnas i en klass.
    interface IEmployee
    {
        // Varje klass som kallar sig Employee ska ha metoden isHappy som returnerar en bool och inte tar några argument.
        public bool isHappy();

        // Kan även lista propeties som ska vara med i detta interfacet. 
    }

    // ---Basklassen Person---
    // Om man skriver att klassen är abstract betyder det att man inte ska/får skapa instanser av denna klass
    // Utan istället skapa instanser av underklasserna till denna. 
    abstract class Person: IComparable<Person>  // IEquatable<Person>
    {

        public string Name;
        public int Age;

        // Har en konstruktor här för dessa två gemensamma variablerna (de finns i både Student & Teacher)
        public Person(string n, int a)
        {
            Name = n;
            Age = a;
        }

        public int Birthyear() => 2021 - Age;

        public override string ToString()
        {
            // Exempel där vi använder base för att komma åt objects metod ToString() då vi hänvisar till object med base här. 
            return base.ToString() + $" och jag heter {Name} och är {Age} år gammal";
            //return $"{Name}, som är {Age} år gammal";
        }

        // ---Exempel utan abstract---
        //public virtual string Description()
        //{
        //    return $"Jag heter {Name} och är {Age} år gammal.";
        //}

        // ---Exempel med abstract---
        // Här tvingar vi child-klasserna att implementera en metod som heter Description som ska returnera
        // string och inte ta några argument. Klassen måste vara abstract för att kunna göra abstract metod.
        public abstract string Description();

        // Används för att jämföra objekt med varandra. Kommer ifrån interfacet, IComparable<Person>
        public int CompareTo(Person other)
        {
            // Returnera 0 om denna personen är likadan
            // Returnera >0 om denna är "större"
            // Returnera <0 om denna är "mindre"

            // Eftersom int har en egen CompareTo()-metod så kan vi lika gärna skriva
            return Age.CompareTo(other.Age);

            // Eller om man vill sortera på namn
            //return Name.CompareTo(other.Name);

            // Kan annars skriva på det här tydliga sättet.
            //if (Age == other.Age)
            //{
            //    return 0;
            //}
            //else if (Age > other.Age)
            //{
            //    return 1;
            //}
            //else
            //{
            //    return -1;
            //}
        }


        // ---Används om man har interfacet IEquatable<Person> --- 
        //public bool Equals([AllowNull] Person other)
        //{
        //    // kod här....
        //}
    }


    // ---Student-klassen---
    class Student: Person
    {
        // Tar bort Name och Age här för at flytta de till basklassen Person
        //public string Name;
        //public int Age;

        public double AverageGrade;

        // Gammalt sätt att sätta konstruktorn
        //public Student(string n, int a, double ag)
        //{
        //    Name = n;
        //    Age = a;
        //    AverageGrade = ag;
        //}

        // -Nytt sätt att sätta konstruktorn-
        public Student(string n, int a, double ag) : base(n, a)
        {

            AverageGrade = ag;
        }

        // ---Exempel utan abstract---
        //public override string Description()
        //{
        //    return $"Jag är en elev. " + base.Description();
        //}

        // ---Exempel med abstract---
        public override string Description()
        {
            return $"Jag är en elev.";
        }


        
        // Istället för att ha denna metod hos både Teacher och student kan vi ha den i basklassen Person
        //public override string ToString()
        //{
        //    return $"{Name}, som är {Age} år gammal";
        //}

    }


    // ---Teacher-klassen---
    class Teacher: Person, IEmployee
    {
        // Tar bort Name och Age här för at flytta de till basklassen Person
        //public string Name;
        //public int Age;

        public int Salary;

        // Nytt sätt att sätta konstruktorn på!
        public Teacher(string n, int a, int s) : base(n, a)
        {
            Salary = s;
        }

        public override string Description()
        {
            return "Jag är en lärare.";
        }

        public bool isHappy()
        {
            if (Salary > 20000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        // Gammalt sätt att sätta konstruktorn
        //public Teacher(string n, int a , int s)
        //{
        //    Name = n;
        //    Age = a;
        //    Salary = s; 
        //}


        // Istället för att ha denna metod hos både Teacher och student kan vi ha den i basklassen Person
        //public override string ToString()
        //{
        //    return $"{Name}, som är {Age} år gammal";
        //}
    }

    // Man kan ärva i flera led. Här nedan så ärver tex Professor ifrån Techer som i sin tur ärver ifrån Person
    //class Professor: Teacher
    //{

    //}

    class Utbildningsansvarig: Person, IEmployee
    {
        public string Course;
        public Utbildningsansvarig(string n, int a, string c): base(n, a)
        {
            Course = c;
        }

        //---Exempel med abstract---
        public override string Description()
        {
            return "Jag är en utbildningsansvarig.";
        }

        public bool isHappy()
        {
            return true;
        }
    }


    //----Program-klassen----
    class Program
    {

        // En metod som skriver ut bara vad klassen är för typ
        //static void PrintPerson(Person p)
        //{
        //    Console.WriteLine(p);
        //}


        static void PrintPerson(Person p)
        {
            Console.WriteLine(p.Description());
        }

        static void Main(string[] args)
        {

            //// ---Funkar ej då man inte får skapa instanser av abstracta klasser.---
            ////var generiskPerson = new Person("Anders", 22);

            var elev_1 = new Student("Jonas Pedersen", 35, 3.5);
            var elev_2 = new Student("Anders Svensson", 25, 2.5);
            var marcus = new Teacher("Marcus Näslund", 100, 1000000);
            var ansvarig = new Utbildningsansvarig("MNO PQR", 60, "Bästa kursen");

            Person[] TUC = new Person[]
            {
                elev_1, elev_2, marcus
            };

            //// -----Exempel för att konvertera en klass till en annan-----
            //// Lägger in våra olika personer i en array
            //var personer = new Person[] { elev_1, elev_2, marcus, ansvarig };

            //foreach (var person in personer)
            //{
            //    // --Varje person behandlas (med "as"-keyword) som en student och sparas i variabeln student av typen Student.
            //    // Om det inte är en student så kommer de fälten ha null. Därav if-satsen nedan
            //    Student student = person as Student;

            //    if (student != null)
            //    {
            //        Console.WriteLine(student.AverageGrade);
            //    }

            //    // --Kan även skriva som nedan. Mycket kortare. Dock skriver den ut en tom sträng vid icke-student--
            //    Console.WriteLine(student?.AverageGrade);


            //    // is-operatorn är snygg att använda om man bara har en if-sats. 
            //    if (person is Student)
            //    {
            //        Console.WriteLine((person as Student).AverageGrade);

            //    }


            //    // Annars kan man använda metoden GetType()
            //    if (person.GetType().Equals(typeof(Teacher)))
            //    {
            //        Console.WriteLine("Det var en lärare!");
            //    }


            //    // Man får null om det är en Teacher eller någon annan klass som inte är Student. 
            //    Console.WriteLine((person as Student).AverageGrade);
            //}


            // -----Exempel med Interface-----
            var personer = new Person[] { elev_1, elev_2, marcus, ansvarig };

            //// Hur sorterar man i klasser/interface?
            //Array.Sort(personer);  // Måste först implementeara IComparable<Person> uppe på Person-klassen.

            //foreach (var person in personer)
            //{
            //    Console.WriteLine(person.ToString());
            //}


            foreach (var person in personer)
            {
                if (person is IEmployee)
                {
                    Console.WriteLine((person as IEmployee).isHappy());
                }
            }

            PrintPerson(elev_1);
            PrintPerson(elev_2);
            PrintPerson(marcus);

            Console.WriteLine("TESTAR...");
            // ....Testar lite olika bara....
            //var rand = new Random();
            //int rand1 = rand.Next(1, 3);
            //Console.WriteLine(rand1);
            List<int> listan = new List<int>() { 3, 5, 7 };
            //Console.WriteLine(listan[0]);
            //listan.Insert(0, 23);
            foreach (var item in listan)
            {
                Console.WriteLine(item);
            }
         



        }

    }   
}
