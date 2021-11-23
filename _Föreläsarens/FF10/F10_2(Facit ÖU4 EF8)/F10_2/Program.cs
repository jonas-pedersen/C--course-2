using System;

namespace F10_2
{
    /*
     * 1. Låt oss återskapa de första uppgifterna ovan utan en enum, med klassarv istället. 
     * Skapa en basklass User med variablerna Username och Password, och passande konstruktor. 
     * Skapa sedan en NormalUser och en AdminUser, som båda ärver från User. 
     * Se till att deras konstruktorer också tar två argument och anropar basklassens konstruktor (: base(username, password)).

      2. Gör klassen User abstrakt och ge den en abstrakt metod "Privilege" som returnerar string. 
         Implementera denna i NormalUser och AdminUser, de ska returnera "Normal" resp. "Admin".

      3. Implementera samma ChangePassword-metod och ToString-metod för User som tidigare.

      4. Testa nu att skapa några olika användare. 
        Lägg dem i en User-array eller en lista. 
        Loopa igenom dem och skriv ut deras användarnamn och privilegier.

      5. Kan du göra ovanstående fast om alla olika Users är structar?
    */
    class Program
    {
        static void Main(string[] args)
        {
            var marcus = new NormalUser("marcus", "123456");
            var admin = new AdminUser("inte marcus", "123456");
            var johndoe = new NormalUser("johndoe", "ABCDEF");

            User[] users = new User[] { marcus, admin, johndoe };

            Console.WriteLine(users[0].Username);

            foreach (var user in users)
            {
                Console.WriteLine(user);
                //Console.WriteLine($"{user.Username} is of type {user.Privilege()}");
            }
        }
    }
}
