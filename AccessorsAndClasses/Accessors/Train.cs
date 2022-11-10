using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessors
{
    class Train : Transport
    {
        public int Carriages { get; set; }
        public int MaxSpeed { get; set; }
        public string Type { get; set; }

        public Train(int year, string color, string mark, int carriages, int maxSpeed, string type) : base(year, color, mark)
        {
            Carriages = carriages;
            MaxSpeed = maxSpeed;
            Type = type;
        }

        public override void Print()
        {
            Console.WriteLine("Поезд: ");
            Console.WriteLine($"\tГод: {Year}\n" +
                              $"\tМарка: {Mark}\n" +
                              $"\tЦвет: {Color}\n" +
                              $"\tЧисло вагонов: {Carriages}\n" +
                               $"\tМаксимальная скорость: {MaxSpeed}\n" +
                              $"\tТип поезда: {Type}\n");
        }
    }
}
