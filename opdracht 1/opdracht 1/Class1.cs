using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_1
{
    public class Opdracht1
    {
        public void Uitvoer()
        {
            Console.WriteLine("Wat is je naam");
            string naam = Console.ReadLine();
            Console.WriteLine("Wat is je leeftijd?");
            int leeftijd = int.Parse(Console.ReadLine());
            Console.WriteLine($"Hallo {naam} je bent {leeftijd} jaar!");
          
        
        }

    }
    
}
