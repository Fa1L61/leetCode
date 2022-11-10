using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessors
{
    class Car : Transport
    {
        public string Manufacturer { get; set; }
        public int Speed { get; set; }
        public int QuantityDoors { get; set; }

        public Car(int year, string color, string mark, string manufacturer, int speed, int quantityDoors) : base(year, color, mark)
        {
            Manufacturer = manufacturer;
            Speed = speed;
            QuantityDoors = quantityDoors;
        }
        public override void Print()
        {
            Console.WriteLine("Машина: ");
            Console.WriteLine($"\tГод: {Year}\n" +
                              $"\tМарка: {Mark}\n" +
                              $"\tЦвет: {Color}\n" +
                              $"\tПроизводитель: {Manufacturer}\n" +
                              $"\tМаксимальная скорость: {Speed}\n" +
                              $"\tЧисло дверей: {QuantityDoors}\n");
        }
    }
}
