using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mémoire.Packing
{
    class _2DPacking
    {

        //instense
        public static _2DPacking instense;
        public _2DPacking()
        {
            instense = this;
        }
        //static variables
        public static int numberOfObjects = 10;
        public static int BinWidth = 10;
        public static int BinHeight = 10;
        public static int numberOfIndividuals = 10;
        public static int numberOfGenerations = 100;
        public static String Unit = "M";
        public static int BluePrintBin;
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
        public void PopulationStart()
        {
            population = new Population();
            FirstGene = new int[numberOfObjects];
            SecondGene = new int[numberOfObjects];
            FirstTemp = new Individual();
            SecondTemp = new Individual();
            //-----------------
            NoneDuplicates1 = new int[numberOfObjects / 2];
            NoneDuplicates2 = new int[numberOfObjects / 2];
            CrossoverPoint = numberOfObjects / 2;
        }

        public int GenerationCount = 0;
        public int WastedSpace = 0;
        public void Start()
        {
            instense.population.objects.NumberOfBinsNeeded();
            while (instense.population.objects.BinsNumberNeeded < instense.population.FittestFitness && instense.GenerationCount < numberOfGenerations)
            {
                ++instense.GenerationCount;


                instense.population.OrderingPopulation();


                //do crossover
                instense.Crossover();

                instense.population.GetTheFittest();

            }

            instense.population.InsertObjects(instense.population.individual[instense.population.FittestIndex]);
            for (int i = 0; i < instense.population.FittestFitness; i++)
            {
                WastedSpace += instense.population.Bins[i].Surface;
            }
        }

        //Crossover function
        public void Crossover()
        {
            Random random = new Random();
            int Index1;
            int Index2;
            int AddingIndex = numberOfIndividuals/2;
            for (int i = 0; i < (numberOfIndividuals/2); i++)
            {
                Index1 = random.Next() % (numberOfIndividuals/2);
                Index2 = random.Next() % (numberOfIndividuals/2);
                while (Index2 == Index1)
                    Index2 = random.Next() % (numberOfIndividuals/2);
                for (int j = 0; j < population.NumberOfObjects; j++)
                {
                    FirstTemp.genes[j] = population.individual[Index1].genes[j];
                    SecondTemp.genes[j] = population.individual[Index2].genes[j];
                    FirstGene[j] = population.individual[Index1].genes[j];
                    SecondGene[j] = population.individual[Index2].genes[j];
                }
                //Do a simple crossover
                SimpleCrossover(FirstTemp, SecondTemp);
                //Do mutation at a precentage
                if (random.Next() % 10 <= 5)
                {
                    Mutation(FirstTemp, SecondTemp);
                }


                //Add the fittest
                AddTheFittest(FirstTemp, SecondTemp, AddingIndex);

                AddingIndex++;
            }
        }



        //Simple crossover function
        public void SimpleCrossover(Individual First, Individual Second)
        {
            int temp;
            int index1 = 0;
            int index2 = 0;
            for (int i = 0; i < CrossoverPoint; i++)
            {
                temp = First.genes[i];
                First.genes[i] = Second.genes[i];
                Second.genes[i] = temp;
            }
            FindDuplicates(First, Second);
            for (int i = 0; i < CrossoverPoint; i++)
            {
                for (int j = CrossoverPoint; j < population.NumberOfObjects; j++)
                {
                    if (First.genes[i] == First.genes[j])
                    {
                        First.genes[j] = NoneDuplicates1[index1];
                        index1++;
                    }
                    if (Second.genes[i] == Second.genes[j])
                    {
                        Second.genes[j] = NoneDuplicates2[index2];
                        index2++;
                    }
                }
            }
        }
        //Find duplicates
        public void FindDuplicates(Individual First, Individual Second)
        {
            int index1 = 0;
            int index2 = 0;
            int test1 = 0;
            int test2 = 0;
            for (int i = 0; i < CrossoverPoint; i++)
            {
                for (int j = 0; j < CrossoverPoint; j++)
                {
                    if (First.genes[j] == FirstGene[i])
                    {
                        test1 = 1;
                    }
                    if (Second.genes[j] == SecondGene[i])
                    {
                        test2 = 1;
                    }
                }
                if (test1 == 0)
                {
                    NoneDuplicates1[index1] = FirstGene[i];
                    index1++;
                }
                else
                {
                    test1 = 0;
                }
                if (test2 == 0)
                {
                    NoneDuplicates2[index2] = SecondGene[i];
                    index2++;
                }
                else
                {
                    test2 = 0;
                }
            }
        }





        //mutation
        public void Mutation(Individual First, Individual Second)
        {
            Random rand = new Random();
            int MutationPoint = rand.Next() % (numberOfObjects / 2);
            int tmp;
            for (int i = MutationPoint; i < MutationPoint + (numberOfObjects / 2); i += 2)
            {
                tmp = First.genes[i];
                First.genes[i] = First.genes[i + 1];
                First.genes[i + 1] = tmp;
            }
            for (int i = MutationPoint; i < MutationPoint + (numberOfObjects / 2); i += 2)
            {
                tmp = Second.genes[i];
                Second.genes[i] = Second.genes[i + 1];
                Second.genes[i + 1] = tmp;
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
        public void AddTheFittest(Individual First, Individual Second, int Index)
        {
            population.InsertObjects(First);
            population.BinsAndObjectsReintialisation();
            population.InsertObjects(Second);
            population.BinsAndObjectsReintialisation();
            FittestFitness = First.fitness;
            SecondFittestFitness = Second.fitness;
            if (GetTheFittest() == 0)
            {
                for (int i = 0; i < population.NumberOfObjects; i++)
                {
                    population.individual[Index].genes[i] = First.genes[i];

                }
                population.individual[Index].fitness = First.fitness;
            }
            else
            {
                for (int i = 0; i < population.NumberOfObjects; i++)
                {
                    population.individual[Index].genes[i] = Second.genes[i];
                }
                population.individual[Index].fitness = Second.fitness;
            }
        }
        //___________________________________________________________________________________________


        public class Object
        {
            public int ID;
            public int Width;
            public int Height;
            public int Surface;
            public int Bin;
            public int Filled = 0;
        }

        public class Objects
        {
            public int NumberOfObjects = numberOfObjects;
            public int AllTheGroupeIsIn;
            public int BinsNumberNeeded = 0;
            public Object[] CurrentObject = new Object[numberOfObjects];
            int BinInterface = BinWidth*BinHeight;
            //create objects
            public Objects()
            {
                for (int i = 0; i < numberOfObjects; i++)
                {
                    CurrentObject[i] = new Object();
                    CurrentObject[i].ID = i + 1;
                }
                AllTheGroupeIsIn = 0;
            }

            //calculate the min number needed for the bins
            public void NumberOfBinsNeeded()
            {
                int sum = 0;
                for (int i = 0; i < NumberOfObjects; i++)
                {
                    sum += CurrentObject[i].Surface;
                }
                BinsNumberNeeded = sum / BinInterface;
                if (BinsNumberNeeded * BinInterface < sum)
                    BinsNumberNeeded++;
            }

            //All IN?
            public Boolean AllIn()
            {
                int test = 0;
                for (int i = 0; i < NumberOfObjects; i++)
                {
                    if (CurrentObject[i].Filled == 0)
                    {
                        test = 1;
                    }
                }
                if (test == 0)
                    return true;
                else
                    return false;
            }
        }


        public class Bin
        {
            public int ID;
            public int Full = 0;
            public int Width = BinWidth;
            public int Height = BinHeight;
            public int Surface = BinWidth*BinHeight;

            public int BestWidthRemaining = BinWidth;
            public int BestWidthRemainingX = 0;
            public int BestWidthRemainingY = 0;

            public int BestHeightRemaining = BinHeight;
            public int BestHeightRemainingX = 0;
            public int BestHeightRemainingY = 0;
            public int[,] BinMatrix ;

            public Bin()
            {
                BinMatrix = new int[BinHeight,BinWidth];
                MatrixIntialisation();
            }
            public void MatrixIntialisation()
            {
                for (int i = 0; i < BinWidth; i++)
                {
                    for (int j = 0; j < BinHeight; j++)
                    {
                        BinMatrix[j,i] = 0;
                    }
                }
            }
        }



        public class Individual
        {
            public int fitness = 0;
            public int genelength = numberOfObjects;
            public int[] genes;
            private int holder;
            Random randomNumber = new Random();
            //create individuals 
            public Individual()
            {
                genes = new int[numberOfObjects];
                for (int i = 0; i < genelength; i++)
                {
                    genes[i] = i;
                }
                for (int i = 0; i < genelength; i++)
                {
                    int num = randomNumber.Next() % genelength;
                    holder = genes[i];
                    genes[i] = genes[num];
                    genes[num] = holder;
                    System.Threading.Thread.Sleep(1);
                }
            }
        }

        public class Population
        {
            static int BinNumber = numberOfObjects;
            static int IndividualNumber = numberOfIndividuals;
            public int NumberOfObjects = numberOfObjects;
            public int FittestIndex;
            public int FittestFitness;
            public Objects objects;
            public Bin[] Bins = new Bin[BinNumber];
            public Individual[] individual = new Individual[IndividualNumber];
            public void ObjectsIntialisation()
            {
                objects = new Objects();
            }
            public void BinAndIndividualsInitialisation()
            {
                for (int i = 0; i < BinNumber; i++)
                {
                    Bins[i] = new Bin();
                    Bins[i].ID = i + 1;
                }
                for (int i = 0; i < IndividualNumber; i++)
                    individual[i] = new Individual();
            }
            public void BinsAndObjectsReintialisation()
            {
                for (int i = 0; i < BinNumber; i++)
                {
                    Bins[i].MatrixIntialisation();
                    Bins[i].Full = 0;
                    Bins[i].Surface = BinWidth*BinHeight;
                    Bins[i].BestWidthRemaining = BinWidth;
                    Bins[i].BestWidthRemainingX = 0;
                    Bins[i].BestWidthRemainingY = 0;
                    Bins[i].BestHeightRemaining = BinHeight;
                    Bins[i].BestHeightRemainingX = 0;
                    Bins[i].BestHeightRemainingY = 0;
                }
                for (int i = 0; i < NumberOfObjects; i++)
                {
                    objects.CurrentObject[i].Filled = 0;
                    objects.CurrentObject[i].Bin = 0;
                }
            }
            //________________________________________________________________________________
            public void GetTheFittest()
            {
                FittestFitness = individual[0].fitness;
                for (int i = 1; i < IndividualNumber; i++)
                {
                    if (FittestFitness > individual[i].fitness)
                    {
                        FittestFitness = individual[i].fitness;
                        FittestIndex = i;
                    }
                }
            }
            //________________________________________________________________________________
            public void OrderingPopulation()
            {
                Individual Temp;
                for (int i = 0; i < individual.Length - 1; i++)
                {
                    for (int j = i + 1; j < individual.Length; j++)
                    {
                        if (individual[j].fitness < individual[i].fitness)
                        {
                            Temp = individual[j];
                            individual[j] = individual[i];
                            individual[i] = Temp;
                        }
                    }
                }
            }
            //________________________________________________________________________________
            public void RunIndividuals()
            {
                for (int i = 0; i < IndividualNumber; i++)
                {
                    InsertObjects(individual[i]);
                    BinsAndObjectsReintialisation();
                }
            }
            //________________________________________________________________________________
            public void CalculateFitness(Individual CurrentIndividual)
            {
                int holder = 0;
                for (int i = 0; i < BinNumber; i++)
                {
                    if (Bins[i].BinMatrix[0, 0] != 0)
                    {
                        holder++;
                    }
                }
                CurrentIndividual.fitness = holder;
            }
            //________________________________________________________________________________
            public void InsertObjects(Individual CurrentIndividual)
            {

                for (int j = 0; j < BinNumber; j++)
                {
                    for (int i = 0; i < NumberOfObjects; i++)
                    {
                        if (Bins[j].Full == 0)
                        {
                            if (objects.CurrentObject[CurrentIndividual.genes[i]].Width > Bins[j].BestWidthRemaining && objects.CurrentObject[CurrentIndividual.genes[i]].Height > Bins[j].BestHeightRemaining && objects.CurrentObject[CurrentIndividual.genes[i]].Surface > Bins[j].Surface)
                            {
                                //Impossible To Add
                            }
                            else
                            {
                                if (objects.CurrentObject[CurrentIndividual.genes[i]].Width <= Bins[j].BestWidthRemaining && objects.CurrentObject[CurrentIndividual.genes[i]].Filled == 0)
                                {
                                    PutInWithWidth(objects.CurrentObject[CurrentIndividual.genes[i]], Bins[j]);
                                    RedefinWidth(Bins[j]);
                                    RedefinHeight(Bins[j]);
                                }
                                if (objects.CurrentObject[CurrentIndividual.genes[i]].Height <= Bins[j].BestHeightRemaining && objects.CurrentObject[CurrentIndividual.genes[i]].Filled == 0)
                                {
                                    PutInWithHeight(objects.CurrentObject[CurrentIndividual.genes[i]], Bins[j]);
                                    RedefinHeight(Bins[j]);
                                    RedefinWidth(Bins[j]);
                                }
                                if (Bins[j].Surface >= objects.CurrentObject[CurrentIndividual.genes[i]].Surface && objects.CurrentObject[CurrentIndividual.genes[i]].Filled == 0)
                                {
                                    PutInWithSurface(objects.CurrentObject[CurrentIndividual.genes[i]], Bins[j]);
                                    RedefinHeight(Bins[j]);
                                    RedefinWidth(Bins[j]);
                                }
                            }
                        }
                    }
                }
                CalculateFitness(CurrentIndividual);
            }

            public void PutInWithWidth(Object CurrentObject, Bin CurrentBin)
            {
                int WidthIndex = CurrentBin.BestWidthRemainingY;
                int HieghtIndex = CurrentBin.BestWidthRemainingX;
                int FlipSwitch = 0;
                int Test = 0;
                int Holder;
            RepeatWidth:
                if (CurrentBin.Height - CurrentBin.BestWidthRemainingX >= CurrentObject.Height)
                {
                    for (int i = 0; i < CurrentObject.Height; i++)
                    {
                        if (CurrentBin.BinMatrix[HieghtIndex, WidthIndex] != 0)
                        {
                            Test = 1;
                        }
                        HieghtIndex++;
                    }
                    HieghtIndex = CurrentBin.BestWidthRemainingX;
                    if (Test == 0)
                    {
                        for (int i = 0; i < CurrentObject.Height; i++)
                        {
                            for (int j = 0; j < CurrentObject.Width; j++)
                            {
                               CurrentBin.BinMatrix[HieghtIndex, WidthIndex] = CurrentObject.ID;
                                WidthIndex++;
                            }
                            WidthIndex = CurrentBin.BestWidthRemainingY;
                            HieghtIndex++;
                        }
                        CurrentObject.Filled = 1;
                        CurrentObject.Bin = CurrentBin.ID;
                        CurrentBin.Surface -= CurrentObject.Surface;
                    }
                }
                else
                {
                    if (FlipSwitch == 0)
                    {
                        if (CurrentObject.Height <= CurrentBin.BestWidthRemaining)
                        {
                            Holder = CurrentObject.Width;
                            CurrentObject.Width = CurrentObject.Height;
                            CurrentObject.Height = Holder;
                            FlipSwitch = 1;
                            goto RepeatWidth;
                        }
                    }
                }
            }


            public void RedefinWidth(Bin CurrentBin)
            {
                CurrentBin.BestWidthRemaining = 0;
                int CurrentWidth = 0;
                int j = 0, Trigger = 0;
                for (int i = 0; i < CurrentBin.Height; i++)
                {
                    while (CurrentBin.BinMatrix[i,j] == 0 && Trigger == 0)
                    {
                        CurrentWidth++;
                        if (j < BinWidth-1)
                            j++;
                        else
                            Trigger = 1;
                    }
                    if (CurrentWidth > CurrentBin.BestWidthRemaining)
                    {

                        CurrentBin.BestWidthRemaining = CurrentWidth;
                        CurrentBin.BestWidthRemainingX = i;
                        CurrentBin.BestWidthRemainingY = j == BinWidth-1 ? (j - CurrentWidth) + 1 : j - CurrentWidth;
                    }
                    CurrentWidth = 0;
                    if (j == BinWidth-1)
                    {
                        j = 0;
                        Trigger = 0;
                    }
                    else
                    {
                        j++;
                        i--;
                    }
                }
                if (CurrentBin.BestHeightRemaining == 0 && CurrentBin.BestWidthRemaining == 0)
                {
                    CurrentBin.Full = 1;
                }
            }

            public void PutInWithHeight(Object CurrentObject, Bin CurrentBin)
            {
                int WidthIndex = CurrentBin.BestHeightRemainingY;
                int HieghtIndex = CurrentBin.BestHeightRemainingX;
                int FlipSwitch = 0;
                int Test = 0;
                int Holder;
            RepeatHieght:
                if (CurrentBin.Width - CurrentBin.BestHeightRemainingY >= CurrentObject.Width)
                {
                    for (int i = 0; i < CurrentObject.Width; i++)
                    {
                        if (CurrentBin.BinMatrix[HieghtIndex, WidthIndex] != 0)
                        {
                            Test = 1;
                        }
                        WidthIndex++;
                    }
                    WidthIndex = CurrentBin.BestHeightRemainingY;
                    if (Test == 0)
                    {
                        for (int i = 0; i < CurrentObject.Width; i++)
                        {
                            for (int j = 0; j < CurrentObject.Height; j++)
                            {
                                CurrentBin.BinMatrix[HieghtIndex, WidthIndex] = CurrentObject.ID;
                                HieghtIndex++;
                            }
                            HieghtIndex = CurrentBin.BestHeightRemainingX;
                            WidthIndex++;
                        }
                        CurrentObject.Filled = 1;
                        CurrentObject.Bin = CurrentBin.ID;
                        CurrentBin.Surface -= CurrentObject.Surface;
                    }
                }
                else
                {
                    if (FlipSwitch == 0)
                    {
                        if (CurrentObject.Width <= CurrentBin.BestHeightRemaining)
                        {
                            Holder = CurrentObject.Width;
                            CurrentObject.Width = CurrentObject.Height;
                            CurrentObject.Height = Holder;
                            FlipSwitch = 1;
                            goto RepeatHieght;
                        }
                    }
                }
            }


            public void RedefinHeight(Bin CurrentBin)
            {
                CurrentBin.BestHeightRemaining = 0;
                int CurrentHeight = 0;
                int j = 0, Trigger = 0;
                for (int i = 0; i < CurrentBin.Width; i++)
                {
                    while (CurrentBin.BinMatrix[j,i] == 0 && Trigger == 0)
                    {
                        CurrentHeight++;
                        if (j < BinHeight-1)
                            j++;
                        else
                            Trigger = 1;
                    }
                    if (CurrentHeight > CurrentBin.BestHeightRemaining)
                    {
                        CurrentBin.BestHeightRemaining = CurrentHeight;
                        CurrentBin.BestHeightRemainingY = i;
                        CurrentBin.BestHeightRemainingX = j == BinHeight - 1 ? (j - CurrentHeight) + 1 : j - CurrentHeight;
                    }
                    CurrentHeight = 0;
                    if (j == BinHeight - 1)
                    {
                        j = 0;
                        Trigger = 0;
                    }
                    else
                    {
                        j++;
                        i--;
                    }
                }
                if (CurrentBin.BestHeightRemaining == 0 && CurrentBin.BestWidthRemaining == 0)
                {
                    CurrentBin.Full = 1;
                }
            }

            public void PutInWithSurface(Object CurrentObject, Bin CurrentBin)
            {
                int WidthFound = 0, j = 0, Trigger = 0, HeightFound = 0, Holder;
                int WidthIndex, HieghtIndex;
                for (int i = 0; i < BinHeight; i++)
                {
                    while (CurrentBin.BinMatrix[i, j] == 0 && Trigger == 0)
                    {
                        WidthFound++;
                        if (j < BinWidth-1)
                            j++;
                        else
                            Trigger = 1;
                    }
                Reapet:
                    if (WidthFound >= CurrentObject.Width)
                    {
                        HieghtIndex = i;
                        WidthIndex = j == BinWidth - 1 ? (j - WidthFound) + 1 : j - WidthFound;
                        if (CurrentBin.Height - HieghtIndex >= CurrentObject.Height)
                        {
                            for (int k = 0; k < CurrentObject.Height; k++)
                            {
                                if (CurrentBin.BinMatrix[HieghtIndex, WidthIndex] == 0)
                                {
                                    HeightFound++;
                                    HieghtIndex++;
                                }
                            }
                            if (HeightFound >= CurrentObject.Height)
                            {
                                HieghtIndex = i;
                                WidthIndex = j == BinWidth - 1 ? (j - WidthFound) + 1 : j - WidthFound;
                                for (int l = 0; l < CurrentObject.Width; l++)
                                {
                                    for (int m = 0; m < CurrentObject.Height; m++)
                                    {
                                        CurrentBin.BinMatrix[HieghtIndex, WidthIndex] = CurrentObject.ID;
                                        HieghtIndex++;
                                    }
                                    HieghtIndex = i;
                                    WidthIndex++;
                                }
                                CurrentObject.Filled = 1;
                                CurrentObject.Bin = CurrentBin.ID;
                                CurrentBin.Surface -= CurrentObject.Surface;
                                return;
                            }

                            HeightFound = 0;
                            j = WidthIndex;
                            Trigger = 0;
                        }
                        else
                                if (CurrentBin.Height - HieghtIndex >= CurrentObject.Width)
                        {
                            Holder = CurrentObject.Width;
                            CurrentObject.Width = CurrentObject.Height;
                            CurrentObject.Height = Holder;
                            goto Reapet;
                        }

                    }
                    WidthFound = 0;
                    if (j == BinWidth - 1)
                    {
                        j = 0;
                        Trigger = 0;
                    }
                    else
                    {
                        j++;
                        i--;

                    }

                }

            }
        }
    }
}