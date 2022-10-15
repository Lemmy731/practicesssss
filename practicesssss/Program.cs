using practicesssss.Implementation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace practicesssss
{
    class Program
    {
       // Consider an array/list of sheep where some sheep may be missing from their place.We need a function
       // that counts the number sheep present in the array (true means present).
        public  class Kata
        {
            public  int CountSheeps(bool[] sheeps)
        {
               
                int count = 0;
                for(int i = 0; i < sheeps.Length; i++)
                {
                    if(sheeps[i] == true)
                    {
                        count = count + 1;
                       Console.WriteLine(count);
                    }
                    else
                    {
                        count = count + 0;
                        
                        Console.WriteLine(count);
                    }
                }
                 return count;
               

                 
          
        }
    }

    static void Main(string[] args)
        {
            Kata kata = new Kata();
            kata.CountSheeps(new bool[] { true, true, true, false,true,true });
            
            
        }

    }
}
