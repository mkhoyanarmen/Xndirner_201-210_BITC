using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xndirner_201_210
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //201
            //int n;
            //do
            //{
            //    Console.WriteLine("Mutqagrel bnakan tiv");
            //    n = int.Parse(Console.ReadLine());
            //} while (!(n > 0));

            //byte count = 0;
            //while (n > 0)
            //{
            //    n /= 10;
            //    count++;
            //}
            //Console.WriteLine(count);

            //202
            //int n;
            //do
            //{
            //    Console.WriteLine("Mutqagrel bnakan tiv");
            //    n = int.Parse(Console.ReadLine());
            //} while (!(n > 0));

            //int sum = 0;
            //while (n > 0)
            //{
            //    sum += n % 10;
            //    n /= 10;
            //}
            //Console.WriteLine(sum);

            //203
            //int n;
            //do
            //{
            //    Console.WriteLine("Mutqagrel bnakan tiv");
            //    n = int.Parse(Console.ReadLine());
            //} while (!(n > 0));

            //int p = 1;
            //while (n > 0)
            //{
            //    p *= n % 10;
            //    n /= 10;
            //}
            //Console.WriteLine(p);

            //204
            //int n;
            //do
            //{
            //    Console.WriteLine("Mutqagrel bnakan tiv");
            //    n = int.Parse(Console.ReadLine());
            //} while (!(n > 0));

            //while (n > 0)
            //{
            //    Console.Write(n % 10 + " ");
            //    n /= 10;
            //}
            //Console.WriteLine();

            //205
            //int n;
            //do
            //{
            //    Console.WriteLine("Mutqagrel bnakan tiv");
            //    n = int.Parse(Console.ReadLine());
            //} while (!(n > 0));

            //byte count = 0;
            //int n2 = n;
            //while (n > 0)
            //{
            //    n /= 10;
            //    count++;
            //}

            //while (count > 0)
            //{
            //    Console.Write(n2 / (int)Math.Pow(10, count-1) + " ");
            //    n2 %= (int)Math.Pow(10, count - 1);
            //    count--;
            //}
            //Console.WriteLine();

            //206
            //int n;
            //do
            //{
            //    Console.WriteLine("Mutqagrel bnakan tiv");
            //    n = int.Parse(Console.ReadLine());
            //} while (!(n > 0));

            //byte count = 0;
            //int n2 = n, sum = 0;
            //while (n > 0)
            //{
            //    n /= 10;
            //    count++;
            //}

            //while (count > 0)
            //{
            //    sum += (n2 % 10) * (int)Math.Pow(10, count - 1);
            //    n2 /= 10;
            //    count--;
            //}
            //Console.WriteLine(sum);

            //207
            //int n;
            //do
            //{
            //    Console.WriteLine("Mutqagrel bnakan tiv");
            //    n = int.Parse(Console.ReadLine());
            //} while (!(n > 0));

            //bool t = false;
            //while (n > 0)
            //{
            //    if (n % 10 == 2)
            //    {
            //        t = true;
            //        break;
            //    }
            //    n /= 10;
            //}
            //Console.WriteLine(t);

            //209
            int n;
            do
            {
                Console.WriteLine("Mutqagrel bnakan tiv");
                n = int.Parse(Console.ReadLine());
            } while (!(n > 0));

            bool t = false;
            while (n > 0)
            {
                if ((n % 10) % 2 != 0)
                {
                    t = true;
                    break;
                }
                n /= 10;
            }
            Console.WriteLine(t);
        }
    }
}
