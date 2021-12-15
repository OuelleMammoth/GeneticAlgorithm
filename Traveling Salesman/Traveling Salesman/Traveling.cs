using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveling_Salesman
{
    class Traveling
    {
        private Random random;

        public List<Salesperson> currentGeneration;
        private List<Salesperson> newGeneration = new List<Salesperson>();
        private List<Salesperson> crossover = new List<Salesperson>();

        private int crossOverInput;
        private string[] optimalBS;

        public Traveling(string[] optimal, int input, List<Salesperson> current)
        {
            random = new Random();
            optimalBS = optimal;
            crossOverInput = input;
            currentGeneration = current;

            fitnessFunction(currentGeneration);
            geneticCrossover();
            fitnessFunction(currentGeneration);
            geneticMutation();
            fitnessFunction(currentGeneration);
        }

        public void fitnessFunction(List<Salesperson> salespeople)
        {

            foreach(Salesperson johnDoe in salespeople)
            {
                johnDoe.FitnessValue = 0;
                for(int i = 0; i < 12; i++)
                {
                    if(johnDoe.PathBS[i].Equals(optimalBS[i]))
                    {
                        johnDoe.FitnessValue = johnDoe.FitnessValue + 1;
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
                for (int i = tenPercentSize; i < currentGeneration.Count * 0.5; i++)
                {
                    Salesperson tempSalesPerson = new Salesperson();
                    int randOne = random.Next(0, crossover.Count);
                    int randTwo = random.Next(0, crossover.Count);

                    for (int j = 0; j < 12; j++)
                    {
                        if (j < 6)
                        {
                            tempSalesPerson.PathBS[j] = crossover[randOne].PathBS[j];
                        }
                        else
                        {
                            tempSalesPerson.PathBS[j] = crossover[randTwo].PathBS[j];
                        }
                    }

                    newGeneration.Add(tempSalesPerson);
                }

                for (int i = Convert.ToInt32(currentGeneration.Count * 0.5); i < currentGeneration.Count; i++)
                {
                    Salesperson tempSalesPerson = new Salesperson();
                    int randOne = random.Next(0, currentGeneration.Count);
                    int randTwo = random.Next(0, currentGeneration.Count);

                    for (int j = 0; j < 12; j++)
                    {
                        if (j < 6)
                        {
                            tempSalesPerson.PathBS[j] = currentGeneration[randOne].PathBS[j];
                        }
                        else
                        {
                            tempSalesPerson.PathBS[j] = currentGeneration[randTwo].PathBS[j];
                        }
                    }

                    newGeneration.Add(tempSalesPerson);
                }
            }
            else if (crossOverInput == 1)
            {
                for (int i = tenPercentSize; i < currentGeneration.Count * 0.5; i++)
                {
                    Salesperson tempSalesPerson = new Salesperson();
                    int randOne = random.Next(0, crossover.Count);
                    int randTwo = random.Next(0, crossover.Count);

                    for (int j = 0; j < 12; j++)
                    {
                        if (j < 3)
                        {
                            tempSalesPerson.PathBS[j] = crossover[randOne].PathBS[j];
                        }
                        else
                        {
                            tempSalesPerson.PathBS[j] = crossover[randTwo].PathBS[j];
                        }
                    }

                    newGeneration.Add(tempSalesPerson);
                }

                for (int i = Convert.ToInt32(currentGeneration.Count * 0.5); i < currentGeneration.Count; i++)
                {
                    Salesperson tempSalesPerson = new Salesperson();
                    int randOne = random.Next(0, currentGeneration.Count);
                    int randTwo = random.Next(0, currentGeneration.Count);

                    for (int j = 0; j < 12; j++)
                    {
                        if (j < 3)
                        {
                            tempSalesPerson.PathBS[j] = currentGeneration[randOne].PathBS[j];
                        }
                        else
                        {
                            tempSalesPerson.PathBS[j] = currentGeneration[randTwo].PathBS[j];
                        }
                    }

                    newGeneration.Add(tempSalesPerson);
                }
            }
            else if (crossOverInput == 2)
            {
                for (int i = tenPercentSize; i < currentGeneration.Count * 0.5; i++)
                {
                    Salesperson tempSalesPerson = new Salesperson();
                    int randOne = random.Next(0, crossover.Count);
                    int randTwo = random.Next(0, crossover.Count);

                    for (int j = 0; j < 12; j++)
                    {
                        if (j < 9)
                        {
                            tempSalesPerson.PathBS[j] = crossover[randOne].PathBS[j];
                        }
                        else
                        {
                            tempSalesPerson.PathBS[j] = crossover[randTwo].PathBS[j];
                        }
                    }

                    newGeneration.Add(tempSalesPerson);
                }

                for (int i = Convert.ToInt32(currentGeneration.Count * 0.5); i < currentGeneration.Count; i++)
                {
                    Salesperson tempSalesPerson = new Salesperson();
                    int randOne = random.Next(0, currentGeneration.Count);
                    int randTwo = random.Next(0, currentGeneration.Count);

                    for (int j = 0; j < 12; j++)
                    {
                        if (j < 9)
                        {
                            tempSalesPerson.PathBS[j] = currentGeneration[randOne].PathBS[j];
                        }
                        else
                        {
                            tempSalesPerson.PathBS[j] = currentGeneration[randTwo].PathBS[j];
                        }
                    }

                    newGeneration.Add(tempSalesPerson);
                }
            }

            currentGeneration.Clear();
            for(int i = 0; i < newGeneration.Count; i++)
            {
                currentGeneration.Add(newGeneration[i]);
            }
        }

        public void geneticMutation()
        {
            currentGeneration.Sort();
            for(int i = Convert.ToInt32(currentGeneration.Count * 0.8); i < newGeneration.Count; i++)
            {
                string[] basePath = new string[12];
                basePath[0] = "100000000000";
                basePath[1] = "010000000000";
                basePath[2] = "001000000000";
                basePath[3] = "000100000000";
                basePath[4] = "000010000000";
                basePath[5] = "000001000000";
                basePath[6] = "000000100000";
                basePath[7] = "000000010000";
                basePath[8] = "000000001000";
                basePath[9] = "000000000100";
                basePath[10] = "000000000010";
                basePath[11] = "000000000001";

                int randOne = random.Next(0, 12);
                int randTwo = random.Next(0, 12);
                int randThree = random.Next(0, 12);
                int randFour = random.Next(0, 12);

                currentGeneration[i].PathBS[randOne] = basePath[randTwo];
                currentGeneration[i].PathBS[randThree] = basePath[randFour];
            }
        }
    }
}
