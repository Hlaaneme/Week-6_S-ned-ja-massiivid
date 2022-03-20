using System;

namespace ACharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada ees- ja perekonnanime
            //programm kuvab mitu 'a' tähte on kasutaja ees- ja perekonnanimes kokku


            Console.WriteLine("Sisesta oma eesnimi:");
            string FirstName = Console.ReadLine();

            Console.WriteLine("Sisesta oma perekonnanimi:");
            string LastName = Console.ReadLine();

            string FullName = $"{FirstName}{LastName}".ToLower();

            Console.WriteLine(FullName);

            int aCounter = 0;

            for(int i = 0; i < FullName.Length; i++)
            {
                if (FullName[i] == 'a')
                {
                    aCounter++;
                }
            }

            if(aCounter != 1)
            {
                Console.WriteLine($"Sinu täisnimes on {aCounter} 'a' tähte.");
            }
            else
            {
                Console.WriteLine($"Sinu täisnimes on {aCounter} 'a' täht.");
            }
            
        }
    }
}
