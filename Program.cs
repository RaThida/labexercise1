using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labexercise1
{
    class Rectangle
    {
        private float fltLength;
        private float fltBreadth;
        public float Area  //part(b)
        {  // a read only property is an accessor that
            //only has a get accessor
            get { return fltLength * fltBreadth; }
        }
        public Rectangle (float GiveMETheLength, float GiveMeTheBreadth)
        {
            fltLength = GiveMETheLength;
            fltBreadth = GiveMeTheBreadth;
        }
        public string GetSize()
        {
            string ToReturn;
            ToReturn = "Then length and breadth of the rectangle is"
                + fltLength.ToString() + "and" + fltBreadth.ToString();
            return ToReturn;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1, r2; //declaration - part(e)
            Console.WriteLine("Give me the length  please: ");
            float length = float.Parse(Console.ReadLine());
            Console.WriteLine("Give me the breadth  please: ");
            float breadth = float.Parse(Console.ReadLine());
            r1 = new Rectangle(length, breadth);

            Console.Write("Give me the length please: ");
            length = float.Parse(Console.ReadLine());
            Console.Write("Give me the breadth please: ");
            breadth = float.Parse(Console.ReadLine());
            r2 = new Rectangle(length, breadth);

            Console.WriteLine("r1: " + r1.GetSize());
            Console.WriteLine("r2: " + r2.GetSize());
            Console.WriteLine("Total area of the 2 rectagles is: ");
            Console.WriteLine((r1.Area + r2.Area).ToString());

        }
    }
}
