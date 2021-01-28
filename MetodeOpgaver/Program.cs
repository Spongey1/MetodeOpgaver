using System;
using System.Collections.Generic;
using System.Linq;

namespace MetodeOpgaver
{
    class Program
    {
        static void Main(string[] args)
        {
            // Metode opgave
            opgave(1, 2);
            opgave5();
            sorting();
            Console.ReadKey();
        }

        static int opgave(int tal1, int tal2)
        {
            List<int> ListeY = new List<int>();
            ListeY.Add(1);
            ListeY.Add(9);

            int average = 0;
            for (int i = 0; i < ListeY.Count(); i++)
            {
                average += ListeY[i];
            }

            Console.WriteLine(tal1 + tal2); // 1.1
            Console.WriteLine(tal1 / tal2); // 1.2
            Console.WriteLine(tal1 % tal2); // 1.3
            Console.WriteLine(ListeY.Max()); // 1.4
            Console.WriteLine((average / ListeY.Count())); // 1.5
            return tal1;
        }

        static Boolean opgave5()
        {
            List<int> x = new List<int>();
            x.Add(1);
            if (x.Contains(1))
            {
                Console.WriteLine("True");
                return true;
            }
            else
            {
                Console.WriteLine("False");
                return false;
            }
        }

        static Boolean sorting()
        {
            List<int> l = new List<int>();
            l.Add(7);
            l.Add(3);
            l.Add(11);

            bool A = true;

            foreach (int num in l)
            {
                if (num == l.First())
                {
                    continue;
                }
                else
                {
                    if (num < (num - 1))
                    {
                        A = true;
                        Console.WriteLine("List is sorted!");
                    }
                    else
                    {
                        A = false;
                        Console.WriteLine("List is not sorted!");
                        break;
                    }
                }
            }
            return A;
        }
    }
}