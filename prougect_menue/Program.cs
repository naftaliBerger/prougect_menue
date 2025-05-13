using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace prougect_menue
{
    internal class Program
    {
        static int[] Series_filling()
        {
            int[]int_series = new int[3];
            do
            {
                Console.WriteLine("plise enter a series");
                string series1 = (Console.ReadLine());
                string[] new_series = series1.Split(' ');
                int_series = new int[new_series.Length];
                for (int i = 0; i < int_series.Length; i++)
                {
                    int_series[i] = int.Parse(new_series[i]);
                }

            } while (int_series.Length < 3);
            return int_series;
        }
        static int[] Series_replacement() 
        {
           return Series_filling();

        }
        static void Introducing_the_series(int[] series)
        {
            for (int i = 0; i < series.Length; i++)
            {
                Console.Write(series[i] + " ");
            }

        }
        static void Reverse_series(int[] series)
        {
            for (int i = series.Length -1; i >= 0; i--)
            {
                Console.Write(series[i] + " ");
            }
        }
        static void Sorted_series(int[] old_series)
        {
            bool booli = false;
            int temp = 0;
            int[] series = (int[])old_series.Clone();
            for (int i = 0;i < series.Length; i++)
            {
                for (int j = i + 1; j < series.Length; j++)
                {
                    if(series[i] > series[j])
                    {
                        booli = true;
                        temp = series[j];
                        series[j] = series[i];
                        series[i] = temp;
                    }
                if(booli == false)
                    {
                        break;
                    }
                    
                }
            }
            for (int i = 0;i < series.Length; i++)
            {
                Console.Write(series[i] + " ");
            }
            
        }
        static void max(int[] series)
        {
            int max = series[0];
            for (int i = 1; i < series.Length; i++) 
            {
                if (series[i] > max)
                {
                    max = series[i];
                }
            }
            Console.WriteLine(max);
        }
        static void min(int[] series)
        {
            int min = series[0];
            for (int i = 1; i < series.Length; i++)
            {
                if (series[i] < min)
                {
                    min = series[i];
                }
            }
            Console.WriteLine(min);
        }
        static void average(int[] series)
        {
            double average = 0;
            int sum = 0;
            int len = 0;
            for (int i = 0; i < series.Length; i++)
            {
                sum += series[i];
            }
            len = series.Length;
            average = sum / Convert.ToDouble(len);
            Console.WriteLine(average);
            
        }
        static void len(int[] series)
        {
            int len = series.Length;
            Console.WriteLine(len);
        }
        static void sum(int[] series)
        {
            int sum = 0;
            for (int i = 0; i < series.Length; i++)
            {
                sum += series[i];
            }
            Console.WriteLine(sum);

        }
        static void Main(string[] args)
        {
            int[] series;
            if (args.Length < 3)
            {
                series = Series_filling();
            }
            else
            {
                series = new int[args.Length];
                for (int i = 0; i < args.Length; i++) 
                {
                    series[i] = int.Parse(args[i]);
                }
                
            }
            int input = 0;
            do
            {
                Console.WriteLine("------menu------\nEnter number 1 to enter a series\n" +
                " number 2 to display the series\n" +
                " number 3 to display the inverted series\n" +
                " number 4 to display the sorted series\n" +
                " number 5 to display the maximum value\n" +
                " number 6 to display the minimum value\n" +
                " number 7 to display the average\n" +
                " number 8 to display the length of the series\n" +
                " number 9 to display the sum of the entire series\n" +
                " number 10 exit");
                input = int.Parse(Console.ReadLine());
                switch (input) 
                {
                    case 1: 
                        {
                            Series_replacement();
                            break;
                        }
                    case 2:
                        {
                            Introducing_the_series(series);
                            break;
                        }
                    case 3:
                        {
                            Reverse_series(series);
                            break;
                        }
                    case 4:
                        {
                            Sorted_series(series);
                            break;
                        }
                    case 5:
                        {
                            max(series); 
                            break;
                        }
                    case 6:
                        {
                            min(series);
                            break;
                        }
                    case 7:
                        {
                            average(series);
                            break;
                        }
                    case 8:
                        {
                            len(series);
                            break;
                        }
                    case 9:
                        {
                            sum(series);
                            break;
                        }
                }
            }
            while (input != 10);
            
            
        }
    }
}
