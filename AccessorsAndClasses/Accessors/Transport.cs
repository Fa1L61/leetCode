using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessors
{
    abstract class Transport
    {
        public int Year { get; set; }
        public string Mark {get; set; }
        public string Color { get; set; }

        public Transport( int year, string mark, string color)
        {
            Year = year;
            Mark = mark;
            Color = color;
        }

        public abstract void Print();

    }
}
