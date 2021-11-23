using System;
using System.Diagnostics.CodeAnalysis;

namespace FF8
{
    interface IEmployee
    {
        public int X { get; set; }

        public bool IsHappy();

        // ...
    }

    abstract class Person: IComparable<Person>
    {
        public string Name;
        public int Age;

        public Person(string n, int a)
        {
            Name = n;
            Age = a;
        }

        public int Birthyear() => 2021 - Age;

        public override string ToString()
        {
            return base.ToString() + $" och jag heter {Name} och är {Age} år gammal.";
            //return $"{Name}, som är {Age} år gammal.";
        }

        public abstract string Description();

        public int CompareTo(Person other)
        {
            // Returnera 0 om den andra personen är likadan
            // Returnera >0 om denna är "större"
            // Returnera <0 om denna är "mindre"

            return Name.CompareTo(other.Name);

            /*
            if (Age == other.Age)
            {
                return 0;
            }
            else if (Age > other.Age)
            {
                return 1;
            }
            else
            {
                return -1;
            }
            */
        }

        //public int CompareTo(object obj)
        //{
            
        //}
    }

    class Student: Person
    {
        public double AverageGrade;

        public Student(string n, int a, double ag): base(n, a)
        {
            AverageGrade = ag;
        }

        public override string ToString()
        {
            return $"Jag är en student och är {Age} år gammal";
            
        }

        public override string Description()
        {
            return $"Jag är en elev. ";
        }
    }

    class Teacher: Person, IEmployee, IComparable<Person>
    {
        public int Salary;

        public Teacher(string n, int a, int s): base(n, a)
        {
            Salary = s;
        }

        public override string Description()
        {
            return "Jag är en lärare.";
        }

        public bool IsHappy()
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
    }

    //class Professor: Teacher
    //{
    //    base
    //}

    class Utbildningsansvarig: Person, IEmployee
    {
        public string Course;

        public Utbildningsansvarig(string n, int a, string c): base(n, a)
        {
            Course = c;
        }

        public override string Description()
        {
            return "Jag är en lärare.";
        }

        public bool IsHappy()
        {
            return true;
        }
    }
        
    

    class Program
    {
        static void PrintPerson(Person p)
        {
            Console.WriteLine(p.Description());
        }

        static void Main(string[] args)
        {
            var elev_1 = new Student("ABC DEF", 35, 3.5);
            var elev_2 = new Student("GHI JKL", 25, 2.5);
            var marcus = new Teacher("Marcus Näslund", 100, 1000000000);
            var ansvarig = new Utbildningsansvarig("MNO PQR", 60, "Bästa kursen");

            //PrintPerson(elev_1);
            //PrintPerson(elev_2);
            //PrintPerson(marcus);

            var personer = new Person[] { elev_1, elev_2, marcus, ansvarig };

            Array.Sort(personer);

            foreach (var person in personer)
            {
                Console.WriteLine(person.ToString());
            }


            //foreach (var person in personer)
            //{
            //    if (person is IEmployee)
            //    {
            //        Console.WriteLine((person as IEmployee).IsHappy());
            //    }
            //}

                //foreach (var person in personer)
                //{
                //    Student student = person as Student;
                //    if (student != null)
                //    {
                //        Console.WriteLine(student.AverageGrade);
                //    }
                //}
        }
    }
}
