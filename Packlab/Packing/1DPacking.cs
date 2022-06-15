using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mémoire.Forms;

namespace Mémoire.Packing
{
    class _1DPacking
    {
        //instense
        public static _1DPacking instense;
        public _1DPacking()
        {
            instense = this;
        }
        
        //Main Variables
        public static int numberOfObjects = 10;
        public static int numberOfIndividuals = 10;
        public static int SizeOfTheBin = 10;
        public static int numberOfGenerations = 100;
        public static String Unit ="M";
        //Code
        public Population population;
        int[] FirstGene;
        int[] SecondGene;
        Individual FirstTemp;
        Individual SecondTemp;
        //Global Variables for the crossover
        int[] NoneDuplicates1;
        int[] NoneDuplicates2;
        int CrossoverPoint;
        public void PoulationStart()
        {
            population = new Population();
            FirstGene = new int[numberOfObjects];
            SecondGene = new int[numberOfObjects];
            //--------------------------------------
            NoneDuplicates1 = new int[numberOfObjects / 2];
            NoneDuplicates2 = new int[numberOfObjects / 2];
            CrossoverPoint = numberOfObjects / 2;
        }
        
        
        public int GenerationCount;
        public void Start()
        {
            instense.population.ObjectGroup.NumberOfBinsNeeded();
            instense.population.GetFittest();
            GenerationCount = 0;
            while (instense.population.ObjectGroup.BinsNumberNeeded < instense.population.fittest && instense.GenerationCount < numberOfGenerations)
            {
                ++instense.GenerationCount;

                //order all individuals
                instense.population.OrderingPopulation();

                //do crossover
                instense.Crossover();


                for (int i = 0; i < numberOfIndividuals; i++)
                {
                    instense.population.Individuals[i].fitness = instense.population.CalculateFitness(instense.population.Individuals[i].genes);
                }

                instense.population.GetFittest();

            }
            instense.population.CalculateFitness(instense.population.GetFittest().genes);
            
        }


        //Crossover function
        public void Crossover()
        {
            Random random = new Random();
            int Index1;
            int Index2;
            int AddingIndex = numberOfIndividuals / 2;
            for (int i = 0; i < numberOfIndividuals / 2; i++)
            {
                Index1 = random.Next() % (numberOfIndividuals / 2);
                Index2 = random.Next() % (numberOfIndividuals / 2);
                while (Index2 == Index1)
                    Index2 = random.Next() % (numberOfIndividuals / 2);
                FirstTemp = population.Individuals[Index1];
                SecondTemp = population.Individuals[Index2];
                for (int k = 0; k < numberOfObjects; k++)
                {
                    FirstGene[k] = population.Individuals[Index1].genes[k];
                    SecondGene[k] = population.Individuals[Index2].genes[k];
                }
                //Do a simple crossover
                SimpleCrossover(FirstGene, SecondGene);

                //Do mutation at a precentage
                if (random.Next() % 10 <= 5)
                {
                    Mutation(FirstGene, SecondGene);
                }


                //Add the fittest
                AddTheFittest(FirstGene, SecondGene, AddingIndex);

                AddingIndex++;
            }
        }



       
        //Simple crossover function
        public void SimpleCrossover(int[] First, int[] Second)
        {
            int NumberOfObjects = numberOfObjects;
            int temp;
            int index1 = 0;
            int index2 = 0;
            for (int i = 0; i < CrossoverPoint; i++)
            {
                temp = First[i];
                First[i] = Second[i];
                Second[i] = temp;
            }
            FindDuplicates(First, Second);
            for (int i = 0; i < CrossoverPoint; i++)
            {
                for (int j = CrossoverPoint; j < NumberOfObjects; j++)
                {
                    if (First[i] == First[j])
                    {
                        First[j] = NoneDuplicates1[index1];
                        index1++;
                    }
                    if (Second[i] == Second[j])
                    {
                        Second[j] = NoneDuplicates2[index2];
                        index2++;
                    }
                }
            }
        }
        //Find duplicates left 
        public void FindDuplicates(int[] First, int[] Second)
        {
            int index1 = 0;
            int index2 = 0;
            int test1 = 0;
            int test2 = 0;
            for (int i = 0; i < CrossoverPoint; i++)
            {
                for (int j = 0; j < CrossoverPoint; j++)
                {
                    if (First[j] == FirstTemp.genes[i])
                    {
                        test1 = 1;
                    }
                    if (Second[j] == SecondTemp.genes[i])
                    {
                        test2 = 1;
                    }
                }
                if (test1 == 0)
                {
                    NoneDuplicates1[index1] = FirstTemp.genes[i];
                    index1++;
                }
                else
                {
                    test1 = 0;
                }
                if (test2 == 0)
                {
                    NoneDuplicates2[index2] = SecondTemp.genes[i];
                    index2++;
                }
                else
                {
                    test2 = 0;
                }
            }
        }





        //mutation
        public void Mutation(int[] First, int[] Second)
        {
            Random rand = new Random();
            int MutationPoint = rand.Next() % (numberOfObjects/2);
            int tmp;
            for (int i = MutationPoint; i < MutationPoint + (numberOfObjects / 2); i += 2)
            {
                tmp = First[i];
                First[i] = First[i + 1];
                First[i + 1] = tmp;
            }
            for (int i = MutationPoint; i < MutationPoint + (numberOfObjects / 2); i += 2)
            {
                tmp = Second[i];
                Second[i] = Second[i + 1];
                Second[i + 1] = tmp;
            }
        }


        int FittestFitness;
        int SecondFittestFitness;
        //get the fittest
        public int GetTheFittest()
        {
            if (FittestFitness <= SecondFittestFitness)
            {
                return 0;
            }
            else
                return 1;
        }


        //Add the Fittest
        public void AddTheFittest(int[] First, int[] Second, int Index)
        {
            FittestFitness = population.CalculateFitness(First);
            SecondFittestFitness = population.CalculateFitness(Second);
            if (GetTheFittest() == 0)
            {
                for (int i = 0; i < numberOfObjects; i++)
                {
                    population.Individuals[Index].genes[i] = First[i];
                }
            }
            else
            {
                for (int i = 0; i < numberOfObjects; i++)
                {
                    population.Individuals[Index].genes[i] = Second[i];
                }
            }
        }


        //--------------------

        public class Object
        {
            public int size;
            public int Bin;
        }

        //--------------------

        public class Objects
        {
            public int NumberOfObjects = numberOfObjects;
            public int BinsNumberNeeded = 0;
            public Object[] RandomObject = new Object[numberOfObjects];

            //create objects
            public Objects()
            {
                for (int i = 0; i < NumberOfObjects; i++)
                {
                    RandomObject[i] = new Object();
                    RandomObject[i].size = 0;
                }
            }

            //calculate the min number needed for the bins
            public void NumberOfBinsNeeded()
            {
                int sum = 0;
                for (int i = 0; i < NumberOfObjects; i++)
                {
                    sum += RandomObject[i].size;
                }
                BinsNumberNeeded = sum / SizeOfTheBin;
                if (BinsNumberNeeded * SizeOfTheBin < sum)
                    BinsNumberNeeded++;
            }
        }

        //--------------------

        public class Individual
        {
            public int fitness = 0;
            public int[] genes = new int[numberOfObjects];
            public int genelength = numberOfObjects;
            private int holder;
            Random randomNumber = new Random();
            //create individuals 
            public Individual()
            {
                for (int i = 0; i < genelength; i++)
                {
                    genes[i] = i;
                }
                for (int i = 0; i < genelength; i++)
                {
                    int num = randomNumber.Next() % numberOfObjects;
                    holder = genes[i];
                    genes[i] = genes[num];
                    genes[num] = holder;
                    System.Threading.Thread.Sleep(1);
                }
                
            }

        }

        //--------------------

        public class Population
        {
            public Individual[] Individuals = new Individual[numberOfIndividuals];
            public int fittest = 0;
            public Objects ObjectGroup;
            public int MaxFitIndex = 0;
            public int BinSize = SizeOfTheBin;
            private Individual Temp;

            //initialize population 
            public void InitializePopulation()
            {
                ObjectGroup = new Objects();
                for (int i = 0; i < numberOfIndividuals; i++)
                {
                    Individuals[i] = new Individual();
                    Individuals[i].fitness = CalculateFitness(Individuals[i].genes);
                }
                GetFittest();
            }


            //Ordering the population
            public void OrderingPopulation()
            {
                for (int i = 0; i < numberOfIndividuals - 1; i++)
                {
                    for (int j = i + 1; j < numberOfIndividuals; j++)
                    {
                        if (Individuals[j].fitness < Individuals[i].fitness)
                        {
                            Temp = Individuals[j];
                            Individuals[j] = Individuals[i];
                            Individuals[i] = Temp;
                        }
                    }
                }
            }


            //Find fittest individual
            public Individual GetFittest()
            {
                int MaxFit = Individuals[0].fitness;
                for (int i = 1; i < numberOfIndividuals; i++)
                {
                    if (MaxFit >= Individuals[i].fitness)
                    {
                        MaxFit = Individuals[i].fitness;
                        MaxFitIndex = i;
                    }
                }
                fittest = MaxFit;
                return Individuals[MaxFitIndex];
            }

            //calculate fitness
            public int CalculateFitness(int[] individuals)
            {
                int CurrentBinSize = BinSize;
                int NumberOfBinsUsed = 1;
                int[] Tester = new int[numberOfObjects];
                for (int i = 0; i < numberOfObjects; i++)
                {
                    ObjectGroup.RandomObject[individuals[i]].Bin = 0;
                    Tester[i] = 0;
                }
                int j;
                for (int i = 0; i < numberOfObjects; i++)
                {
                    if (CurrentBinSize - ObjectGroup.RandomObject[individuals[i]].size >= 0 && Tester[i] == 0)
                    {
                        CurrentBinSize -= ObjectGroup.RandomObject[individuals[i]].size;
                        ObjectGroup.RandomObject[individuals[i]].Bin = NumberOfBinsUsed;
                        Tester[i] = 1;
                        for (j = i + 1; j < individuals.Length; j++)
                        {
                            if (CurrentBinSize - ObjectGroup.RandomObject[individuals[j]].size >= 0 && Tester[j] == 0)
                            {
                                CurrentBinSize -= ObjectGroup.RandomObject[individuals[j]].size;
                                ObjectGroup.RandomObject[individuals[j]].Bin = NumberOfBinsUsed;
                                Tester[j] = 1;
                            }
                        }
                    }
                    else if (Tester[i] == 0)
                    {
                        NumberOfBinsUsed++;
                        CurrentBinSize = BinSize;
                        CurrentBinSize -= ObjectGroup.RandomObject[individuals[i]].size;
                        ObjectGroup.RandomObject[individuals[i]].Bin = NumberOfBinsUsed;
                        Tester[i] = 1;
                        for (j = i + 1; j < individuals.Length; j++)
                        {
                            if (CurrentBinSize - ObjectGroup.RandomObject[individuals[j]].size >= 0 && Tester[j] == 0)
                            {
                                CurrentBinSize -= ObjectGroup.RandomObject[individuals[j]].size;
                                ObjectGroup.RandomObject[individuals[j]].Bin = NumberOfBinsUsed;
                                Tester[j] = 1;
                            }
                        }

                    }
                }
                return NumberOfBinsUsed;
            }
        }
    }
}
