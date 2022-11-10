using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessors
{
    class Airplane : Transport
    {
        public int Speed { get; set; }
        public int Number { get; set; }
        public int CountOfPassagire { get; set; }

        public Airplane (int year, string color, string mark, int speed, int number, int countOfPassagire) : base(year, color, mark)
        {
            Speed = speed;
            Number = number;
            CountOfPassagire = countOfPassagire;
        }

        public override void Print()
        {
            Console.WriteLine("Самолет: ");
            Console.WriteLine($"\tГод: {Year}\n" +
                              $"\tМарка: {Mark}\n" +
                              $"\tЦвет: {Color}\n" +
                              $"\tЧисло пассажиров: {CountOfPassagire}\n" +
                              $"\tМаксимальная скорость: {Speed}\n" +
                              $"\tНомер самолета: {CountOfPassagire}\n");
        }

    }
}
