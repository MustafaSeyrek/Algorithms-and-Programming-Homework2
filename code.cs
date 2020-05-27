using System;

namespace homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int countA = 0, countB = 0, countC = 0, maxA = 0, maxB = 0, maxC = 0;           
            Console.Write(" n= ");
            int n = Convert.ToInt32(Console.ReadLine());
            char[,] arr = new char[n, n];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    char letter = Convert.ToChar(random.Next(65, 68));
                    arr[i, j] = letter;
                    if (arr[i, j] == 'A')
                    {
                        countA++;
                        countB = 0;
                        countC = 0;
                    }
                    if (arr[i, j] == 'B')
                    {
                        countB++;
                        countA = 0;
                        countC = 0;
                    }
                    if (arr[i, j] == 'C')
                    {
                        countC++;
                        countA = 0;
                        countB = 0;
                    }
                    if (countA >= maxA)
                        maxA = countA;
                    if (countB >= maxB)
                        maxB = countB;
                    if (countC >= maxC)
                        maxC = countC;
                }                
                countA = 0;
                countB = 0;
                countC = 0;                
            }
            //write matris
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(" " + arr[i, j]);
                }
                Console.WriteLine();
            }
            //en  cok yazılanı bulma ve ekrana bastırma.Aynı varsa sadece birini bastırıyor.
            if (maxA >= maxB && maxA >= maxC)
                Console.WriteLine("letter= A" + "\t length= " + maxA);
            else if (maxB >= maxA && maxB >= maxC)
                Console.WriteLine("letter= B" + "\t length= " + maxB);
            else
                Console.WriteLine("letter= C" + "\t length= " + maxC);
            Console.ReadLine();
        }
    }
}