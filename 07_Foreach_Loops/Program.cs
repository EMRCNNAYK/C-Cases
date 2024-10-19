using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Foreach_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Loops - Basic
            //string[] cities = { "Milano", "Roma", "Budapest", "Istanbul", "London", "Washington" };

            //foreach (string city in cities) 
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 8, 45, 96, 2, 15, 336, 174852, 360, 2145, 1163 };
            //Console.WriteLine("----- EVEN NUMBERS -----");

            //foreach (int i in numbers)
            //{
            //    if(i%2== 0)
            //    { 
            //        Console.WriteLine(i);
            //    }
            //}

            //int sum = 0;
            //foreach (int i in numbers)
            //{
            //    sum += i;
            //}
            //Console.WriteLine("SUM OF ARRAY : "+sum);

            //string name = "Alexander";
            //foreach(char c in name)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion

            #region STUDENT EXAM SYSTEM

            Console.WriteLine("---------- EXAM RECORD SYSTEM ----------\n\n");

            Console.Write("Enter the NUMBER of STUDENT : ");
            int studentCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\n\n");

            string[] studentName = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            

            for (int i=0;i<studentCount;i++)
            {
                Console.Write($"{i+1}. student's name : ");
                studentName[i] = Console.ReadLine();

                double total = 0;

                for (int j=0;j<3;j++)
                {
                    Console.Write($"{studentName[i]} 's {j+1}. exam grade :  ");
                    double value = Convert.ToDouble(Console.ReadLine());

                    total += value;
                }
                studentExamAvg[i] = total/3;
            }

            for (int i=0;i<studentCount; i++)
            {
                Console.WriteLine($"{studentName[i]}'s average : {studentExamAvg[i]}");
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentName[i]} is passed :) ");
                }
                else if (studentExamAvg[i] < 50)
                {
                    Console.WriteLine($"{studentName[i]} is not passed , try again :( ");
                }
            }
                


            #endregion


            Console.Read();

        }
    }
}
