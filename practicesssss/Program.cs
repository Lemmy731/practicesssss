using practicesssss.Implementation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace practicesssss
{
    class Program
    {
        //Create a function that accepts 2 string arguments and returns an integer of the count of occurrences 
        //the 2nd argument is found in the first one.

        public static int StrCount(string str, string letter)
        {
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == char.Parse(letter))
                {
                    count = count + 1;
                }
                else
                {
                    count = count + 0;
                }
            }
            return count;
        }


        public static void Main(string[] args)
        {
            
            Console.WriteLine(Program.StrCount("comemmmmmmm", "m"));
        }
    }

}
