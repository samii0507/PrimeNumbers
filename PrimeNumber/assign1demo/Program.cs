using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign1demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tC# console application for find which integer between a range of integers of your choice has \r\n\t\ttthe maximum number of divisors and which numbers are the prime numbers");
            
            // Declare variables
            int startNum , endNum , isPrime  ,PrimeCount =0 ;

            // Prompt the user to enter the starting number of the range
            Console.WriteLine("\nEnter the starting Number of the range: ");
            startNum = Convert.ToInt32(Console.ReadLine());

            // Prompt the user to enter the ending number of the range
            Console.WriteLine("\nEnter the Ending Number of the range: ");
            endNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\nPrime Numbers between {0} and {1} ",startNum,endNum);
            Console.WriteLine("==================================");
            if(startNum==endNum)
            {
                // If the range is 0, display appropriate message
                Console.WriteLine("\nThe range is 0");
                Console.WriteLine("\nThere is no prime Numbers in 0 range");
                Console.ReadKey();
            }
            else if (startNum>endNum)
            {
                // Swap the values if the starting number is greater than the ending number
                int l;
                l = startNum;
                startNum = endNum;
                endNum = l;

                // Find and display prime numbers in the range
                for (int i = startNum; i <= endNum; i++)
                {
                    isPrime = 0;
                    if (i > 1)
                    {
                        for (int j = 2; j < i; j++)
                            if (i % j == 0)
                            {
                                isPrime = 1;
                                break;
                            }
                        if (isPrime == 0)
                        {
                            PrimeCount++;
                            Console.WriteLine(i + "");
                        }
                    }
                }
                // Find the number with the maximum number of divisors within the range
                int maxDivsors = 0;
                int maxDivNumber = 0;
                for (int k = startNum; k <= endNum; k++)
                {
                    int divCount = 0;
                    for (int p = 1; p <= k; p++)
                    {
                        if (k % p == 0)
                        {
                            divCount++;
                        }
                    }
                    if (divCount > maxDivsors)
                    {
                        maxDivsors = divCount;
                        maxDivNumber = k;
                    }
                }
                // Display the results
                Console.WriteLine();
                Console.WriteLine("\n \t\tThere are {0} prime numbers.", PrimeCount);
                Console.WriteLine("\n \t\tThe number with the maximum number of divisors within the range: {0}", maxDivNumber);
                Console.ReadKey();
            } else if (startNum< endNum)
            {
                // Find and display prime numbers in the range
                for (int i = startNum; i <= endNum; i++)
                {
                    isPrime = 0;
                    if (i > 1)
                    {
                        for (int j = 2; j < i; j++)
                            if (i % j == 0)
                            {
                                isPrime = 1;
                                break;
                            }
                        if (isPrime == 0)
                        {
                            PrimeCount++;
                            Console.WriteLine(i + "");
                        }
                    }
                }
                // Find the number with the maximum number of divisors within the range
                int maxDivsors = 0;
                int maxDivNumber = 0;
                for (int k = startNum; k <= endNum; k++)
                {
                    int divCount = 0;
                    for (int p = 1; p <= k; p++)
                    {
                        if (k % p == 0)
                        {
                            divCount++;
                        }
                    }
                    if (divCount > maxDivsors)
                    {
                        maxDivsors = divCount;
                        maxDivNumber = k;
                    }
                }
                // Display the results
                Console.WriteLine();
                Console.WriteLine("\n \t\tThere are {0} prime numbers.", PrimeCount);
                Console.WriteLine("\n \t\tThe number with the maximum number of divisors within the range: {0}", maxDivNumber);
                Console.ReadKey();
            }

           
        }
        
    }
}
