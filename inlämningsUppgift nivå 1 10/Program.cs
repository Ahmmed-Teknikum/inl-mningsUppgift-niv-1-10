using System;

namespace inlämningsUppgift_._nivå1_._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int antalJämna = 0; 

            
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Skriv in ett heltal: ");
                int tal = int.Parse(Console.ReadLine()); 

               
                if (tal % 2 == 0)
                {
                    antalJämna++; 
                }
            }

            
            Console.WriteLine("Antalet jämna tal är: " + antalJämna);
        }
    }
}