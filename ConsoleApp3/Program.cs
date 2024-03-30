using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args);
            public class Rectangle
        {
            public int Xcoord { get; set; }
            public int Ycoord { get; set; }
            public int Perimeter()
            {
                return 2 * (Math.Abs(Xcoord) + Math.Abs(Ycoord));
            }
        }
    }
    }
}
