using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Diagnostics;
using System.Threading;

namespace CrazyProduct
{
    public class Program
    {
        static void Main(string[] args)
        {
            var product = Product(5, 4);
            Console.WriteLine($"Sum of product:{product}");
            Console.ReadLine();
        }

        public static BigInteger Product(long n, long c){
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            BigInteger product = new BigInteger(1);
		
                BigInteger sum = new BigInteger(0);
                for(long i = 1; i < n; i++){
                    long start = i - c;
                    
                    if(start > 0){
                        product = BigInteger.Divide( product, start);
                    }
                    
                    product = BigInteger.Multiply(product, i);
                    sum = BigInteger.Add(sum, product);
                }
                stopwatch.Stop();
                Console.WriteLine($"Time elapsed{stopwatch.ElapsedMilliseconds}" );
                return sum;
        }
    }
}
