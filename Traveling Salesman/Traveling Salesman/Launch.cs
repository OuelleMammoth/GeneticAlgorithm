using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveling_Salesman
{
    class Launch
    {
        public static ThePath optimalPath = new ThePath();
        static void Main() 
        {
            int crossoverValue = 4;
            Console.WriteLine("Welcome to the Travling Salesman Problem");
            Console.WriteLine("This program is designed to use a Genetic Algorithm in order to find a passable solution for the problem");
            Console.WriteLine("For the genetic algorithm to work properly, some data is required");
            Console.WriteLine();
            Console.WriteLine("Please enter the number of individuals there will be in each generation:");
            int peoplePerGen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Please enter the number of generations the program will go through:");
            int numberOfGen = Convert.ToInt32(Console.ReadLine());
            
            while(crossoverValue == 4)
            {
                Console.WriteLine();
                Console.WriteLine("Please enter either 0, 1, or 2 to change the style of genetic crossover that will occur:");
                crossoverValue = Convert.ToInt32(Console.ReadLine());
                if(crossoverValue != 0 && crossoverValue != 1 && crossoverValue != 2)
                {
                    crossoverValue = 4;
                    Console.WriteLine("Invalid Input");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Please wait for calculations");
            Console.WriteLine();

            List<Salesperson> currentGeneration = new List<Salesperson>();

            for(int i = 0; i < peoplePerGen; i++)
            {
                Salesperson joe = new Salesperson();
                currentGeneration.Add(joe);
            }

            for(int i = 0; i < numberOfGen; i++)
            {
                Traveling traveling = new Traveling(optimalPath.APath, crossoverValue, currentGeneration);
                
                currentGeneration = traveling.currentGeneration;
            }

            currentGeneration.Sort();

            string[] bestCreatedPath = currentGeneration[0].PathBS;
            int bestFV = currentGeneration[0].FitnessValue;

            Console.WriteLine("After going through " + numberOfGen + " generations, the best path had a fitness value of " + bestFV);
            Console.WriteLine("The optimal path was:");
            foreach(string oBS in optimalPath.APath)
            {
                Console.WriteLine(oBS);
            }
            Console.WriteLine();
            Console.WriteLine("The best path from the various saleman was:");
            foreach (string bBS in bestCreatedPath)
            {
                Console.WriteLine(bBS);
            }

            Console.WriteLine();
            Console.WriteLine("Press enter to exit");
            string end = Console.ReadLine();
        }
    }
}
