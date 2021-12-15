using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveling_Salesman
{
    class Traveling
    {
        private Random random = new Random();

        List<Salesperson> currentGeneration;
        List<Salesperson> newGeneration = new List<Salesperson>();
        List<Salesperson> crossover = new List<Salesperson>();

        private int crossOverInput;
        private long[] optimalBS;

        public Traveling(long[] optimal, int input, List<Salesperson> current)
        {
            optimalBS = optimal;
            crossOverInput = input;
            currentGeneration = current;

            geneticCrossover();
            geneticMutation();


        }

        public void fitnessFunction(List<Salesperson> salespeople)
        {
            foreach(Salesperson johnDoe in salespeople)
            {
                for(int i = 0; i < 12; i++)
                {
                    if(johnDoe.PathBS[i] == optimalBS[i])
                    {
                        johnDoe.FitnessValue = johnDoe.FitnessValue++;
                    }
                }
            }
        }



        public void geneticCrossover()
        {
            currentGeneration.Sort();
            newGeneration.Clear();

            int tenPercentSize = Convert.ToInt32(currentGeneration.Count * 0.1);

            for (int i = 0; i < tenPercentSize; i++)
            {
                newGeneration.Add(currentGeneration[i]);
                crossover.Add(currentGeneration[i]);
            }

            if (crossOverInput == 0)
            {
                for (int i = tenPercentSize; i < currentGeneration.Count; i++)
                {
                    int randOne = random.Next(0, crossover.Count);
                    int randTwo = random.Next(0, crossover.Count);

                    for (int j = 0; j < 12; j++)
                    {
                        if (j < 6)
                        {
                            newGeneration[i].PathBS[j] = crossover[randOne].PathBS[j];
                        }
                        else
                        {
                            newGeneration[i].PathBS[j] = crossover[randTwo].PathBS[j];
                        }
                    }

                }
            }
            else if (crossOverInput == 1)
            {
                for (int i = tenPercentSize; i < currentGeneration.Count; i++)
                {
                    int randOne = random.Next(0, crossover.Count);
                    int randTwo = random.Next(0, crossover.Count);

                    for (int j = 0; j < 12; j++)
                    {
                        if (j < 3)
                        {
                            newGeneration[i].PathBS[j] = crossover[randOne].PathBS[j];
                        }
                        else
                        {
                            newGeneration[i].PathBS[j] = crossover[randTwo].PathBS[j];
                        }
                    }

                }
            }
            else if (crossOverInput == 2)
            {
                for (int i = tenPercentSize; i < currentGeneration.Count; i++)
                {
                    int randOne = random.Next(0, crossover.Count);
                    int randTwo = random.Next(0, crossover.Count);

                    for (int j = 0; j < 12; j++)
                    {
                        if (j < 9)
                        {
                            newGeneration[i].PathBS[j] = crossover[randOne].PathBS[j];
                        }
                        else
                        {
                            newGeneration[i].PathBS[j] = crossover[randTwo].PathBS[j];
                        }
                    }

                }
            }
            else
            {
                for (int i = tenPercentSize; i < currentGeneration.Count; i++)
                {
                    int randOne = random.Next(0, crossover.Count);
                    int randTwo = random.Next(0, crossover.Count);

                    for (int j = 0; j < 12; j++)
                    {
                        if (j < 11)
                        {
                            newGeneration[i].PathBS[j] = crossover[randOne].PathBS[j];
                        }
                        else
                        {
                            newGeneration[i].PathBS[j] = crossover[randTwo].PathBS[j];
                        }
                    }

                }
            }
        }

        public void geneticMutation()
        {
            for(int i = Convert.ToInt32(newGeneration.Count * 0.8); i < newGeneration.Count; i++)
            {
                int randOne = random.Next(0, 12);
                int randTwo = random.Next(0, 12);

                long tempPathBS = newGeneration[i].PathBS[randOne];

                newGeneration[i].PathBS[randOne] = newGeneration[i].PathBS[randOne];
                newGeneration[i].PathBS[randTwo] = tempPathBS;
            }
        }
    }
}
