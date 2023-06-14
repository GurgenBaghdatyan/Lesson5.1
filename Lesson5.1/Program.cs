using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace Lesson5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a= new int[500] ;
            int n=Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            double s=0, count=0;
            for (int i=0; i<n; i++) 
            {
                a[i] = 20- rnd.Next(50);
                Console.Write(a[i]+" ");
            }
            for (double i = 0; i < n; i++)
            {
                if (a[Convert.ToInt32(i)]>0)
                {
                    s += a[Convert.ToInt32(i)];
                    count++;
                }
            }
            Console.WriteLine();
            Console.WriteLine(s/count);
            count=0;
            s = 0;
            for (double i = 0; i < n; i++)
            {
                if (a[Convert.ToInt32(i)] > 0)
                {
                    s += Math.Pow(a[Convert.ToInt32(i)],2);
                    count++;
                }
            }
            Console.WriteLine(Math.Sqrt(s/count));
            count = 0;
            s = 0;
            for (double i = 0; i < n; i++)
            {
                if (a[Convert.ToInt32(i)] < 0)
                {
                    s += Math.Pow(a[Convert.ToInt32(i)], 2);
                    count++;
                }
            }
            Console.WriteLine(Math.Sqrt(s / count));
            s = 0;
            count= 0;
            for (double i = 0; i < n; i++)
            {
                if (a[Convert.ToInt32(i)] < 0)
                {
                    s += a[Convert.ToInt32(i)];
                    count++;
                }
            }
            Console.WriteLine(s / count);
            s = 0;
            count = 0;
            for (double i = 0; i < n; i++)
            {
                if (Convert.ToInt32(i)%2 == 0)
                {
                    s += a[Convert.ToInt32(i)];
                    count++;
                }
            }
            Console.WriteLine(s / count);
            s = 1;
            count = 0;
            for (double i = 0; i < n; i++)
            {
                if (Convert.ToInt32(i) % 2 == 0)
                {
                    s *= a[Convert.ToInt32(i)];
                }
            }
            Console.WriteLine(s / count);
            s = 1;
            count = 0;
            for (double i = 0; i < n; i++)
            {
                if (Convert.ToInt32(i) % 2 == 1)
                {
                    s *= a[Convert.ToInt32(i)]* a[Convert.ToInt32(i)];
                    
                }
            }
            Console.WriteLine(s);
            s = 1;
            count = 0;
            for (double i = 0; i < n; i++)
            {
                if (Convert.ToInt32(i) % 2 == 1)
                {
                    s +=Math.Abs( a[Convert.ToInt32(i)]);
                    
                }
            }
            Console.WriteLine(s);
            Console.Write("k = ");
            double k=Convert.ToDouble(Console.ReadLine());
            count=0;
            for (double i = 0;i < n;i++)
            {
                if(i%k==0) 
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            int countPos=0,countNeg=0;
            for (double i=0;i<n;i++)
            {
                if (a[Convert.ToInt32(i)]>0)
                {
                    countPos++;
                }
                else if (a[Convert.ToInt32(i)]<0)
                {
                    countNeg++;
                }
            }
            s = 0;
            Console.WriteLine($"We have {countNeg} negativ elements and {countPos} positive elements");
            Console.Write("a = ");
            int a1=Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c = ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("d = ");
            int d = Convert.ToInt32(Console.ReadLine());
            for (int i=a1;i<=b;i++) 
            {
                s += a[i];
            }
            Console.WriteLine("Sum of [a;b;] = "+s);
            s=1;
            for (int i=c+1;i<d;i++)
            {
                s *= a[i];
            }
            Console.WriteLine(s);
            Console.WriteLine(b-a1-1);
            s=0;
            for (int i=0;i<n;i++)
            {
                if (Math.Abs(a[i])<k)
                {
                    s += Math.Pow(a[i],3);
                }
            }
            Console.WriteLine(s);
            s=1;
            for (int i=0;i<n;i++)
            {
                if (Math.Abs(a[i])<k)
                {
                    s *= a[i];
                }
            }
            Console.WriteLine(s);
            count=0;
            for (int i=0;i<n;i++)
            {
                if (Math.Abs(a[i])<k)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            s=0;
            count=0;
            for (int i=0;i<n;i++)
            {
                if (i%k==0) 
                {
                    s += a[i];
                    count++;    
                }
            }
            Console.WriteLine(s/count);
            s=0;
            for (int i=0;i<n;i++)
            {
                if (i%k==0) 
                {
                    s += a[i];
                }
            }
            Console.WriteLine(s);
            s = 1;
            for (double i=0;i<n;i++)
            {
                if (a[Convert.ToInt32(i)]-i>0)
                {
                    s *= a[Convert.ToInt32(i)];
                }    
            }
            Console.WriteLine(s);
            s=0;
            count=0;
            for(int i=0;i<n;i++)
            {
                int q=Convert.ToInt32(a[i]);
                if (q%k==0)
                {
                    s+= Math.Pow(a[i],2);
                    count++;
                }
            }
            Console.WriteLine(Math.Sqrt(s/count));

            Console.ReadKey();
        }
    }
}
