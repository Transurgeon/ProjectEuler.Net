﻿using System;
using System.Collections;
using System.Numerics;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(findCombinatoricSelections(1000000));
            //Console.WriteLine(isCombinatoricGreater(23, 10, 1000000));
        }

        static int findCombinatoricSelections(int max)
        {
            int count = 0;
            for (int i = 22; i<= 100; i++)
            {
                for (int j = 1; j<= i; j++)
                {
                    if (isCombinatoricGreater(i,j,max))
                    {
                        Console.WriteLine(i + "," + j);
                        count++;
                    }
                }
            }
            return count;
        }
        static bool isCombinatoricGreater(int i, int j, int max)
        {

            if (getFactorial(i) / (getFactorial(j) * getFactorial(i - j)) > max) {
                Console.WriteLine(getFactorial(i) / (getFactorial(j) * getFactorial(i - j)));
                return true;
            }
            return false;
        }
        static BigInteger getFactorial(int num)
        {
            var product = new BigInteger(1);
            for (int i = num; i >= 2; i--)
            {
                product *= i;
            }
            return product;
        }
    }
}


    


