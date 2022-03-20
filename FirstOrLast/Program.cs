using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada ees- ja perekonnanime
            //programm kontrollib andmete pikkust
            //programm kuvab kumb nendest on pikkem, kas ees- või perekonnanimi

            Console.WriteLine("Sisesta oma eesnimi:");

            string FirstName = Console.ReadLine();
            Console.WriteLine("Sisesta oma perekonnanimi:");
            string LastName = Console.ReadLine();

            Console.WriteLine($"Teie eesnimes on {FirstName.Length} sümbolit ja perekonnanimes {LastName.Length} sümbolit.");

            if(FirstName.Length > LastName.Length)
            {
                Console.WriteLine("Teie eesnimi on pikem kui perekonnanimi.");
            }
            else if(FirstName.Length < LastName.Length)
            {
                Console.WriteLine("Teie prekonnanimi on pikem kui eesnimi.");
            }
            else
            {
                Console.WriteLine("Teie mõlemad nimed on pikkuselt võrdsed.");
            }
               
           

            




          
        }
    }
}
