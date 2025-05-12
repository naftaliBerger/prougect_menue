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
            return null;
        }
        static void Series_replacement(int[] series) 
        {
            for (int i = 0; i < series.Length; i++)
            {
                Console.WriteLine(i);
            }
               
        }
        static int[] Introducing_the_series()
        {
            return null ;
        }
        static int[] Reverse_series()
        {
            return null ;
        }
        static int[] Sorted_series()
        {
            return null ;
        }
        static int max()
        {
            return 0 ;
        }
        static int min()
        {
            return 0;
        }
        static int average()
        {
            return 0;
        }
        static int len()
        {
            return 0;
        }
        static int sum()
        {
            return 0;
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
                            Series_replacement(series);
                            break;
                        }
                    case 2:
                        {
                            Introducing_the_series();
                            break;
                        }
                    case 3:
                        {
                            Reverse_series();
                            break;
                        }
                    case 4:
                        {
                            Sorted_series();
                            break;
                        }
                    case 5:
                        {
                            max(); 
                            break;
                        }
                    case 6:
                        {
                            min();
                            break;
                        }
                    case 7:
                        {
                            average();
                            break;
                        }
                    case 8:
                        {
                            len();
                            break;
                        }
                    case 9:
                        {
                            sum();
                            break;
                        }
                }
            }
            while (input != 10);
            
            
        }
    }
}
