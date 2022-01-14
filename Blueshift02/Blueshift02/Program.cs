using System;

namespace Blueshift02
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 50, 60, 40, 30, 90, -5, 40, 50, 30, 40};
            Console.WriteLine("Input array elements:");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write(array1[i] + " ");
                
            }
                Console.WriteLine();
                //first calculation 
                // p value
                int p;
                Console.WriteLine();
                Console.WriteLine("Enter a 'p' value : ");
                p = Convert.ToInt32(Console.ReadLine());
                // formula for first value 
                double firstValue = ((array1[0] + array1[1] + array1[2]) * 1) * 1 / p * 1;
                //Console.WriteLine();
                //Console.Write("First Value is:  " + (firstValue).ToString("0.00"));

                //alfa value 
                double a;
                Console.WriteLine();
                Console.WriteLine("Enter a 'alfa' value : ");
                a = Convert.ToDouble(Console.ReadLine());
                double[] array2 = new double[array1.Length];
                array2[0] = firstValue;
                for (int i = 1; i < array1.Length; i++)
                {
                    array2[i] = calSecondValue(a, array1[i], array2[i - 1]);
                }

                Console.WriteLine();
                for (int i = 0; i < array2.Length; i++)
                {
                    Console.Write(array2[i].ToString("F"));
                    Console.WriteLine();
                }

            }
        
        public static double calSecondValue(double a, double n, double f)
                {
                    
                    return a * n + (1 - a) * f;
                }   
        
     }
 }

            