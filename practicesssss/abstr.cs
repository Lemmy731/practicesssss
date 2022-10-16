using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicesssss
{

    
    public abstract class Shape
    {
        public double Length { get; set; }
        public abstract double Area();
       
        
       
    }

    public class Circle : Shape
    {
      
        public override double Area()
        {
           return  Length * Length;
        }

        
    }
    public class Triangle : Shape
    {
        public override Double Area()
        {
            return Length + Length;
        }
        public  Double Area233()
        {
            return Length * Length;
        }
    }

    public class Square : Shape
    {
        public override Double Area()
        {
            return Length * Length * Length;
        }
       
    }




}
