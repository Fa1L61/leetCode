using System;


namespace Accessors
{
    class Program
    {
        static void Main(string[] args)
        {
            Transport[] arr = new Transport[6];
            Random rand = new Random();

            arr[0] = new Car(2000, "White", "Mercedes", "Germany", 300, 2);
            arr[1] = new Airplane(2022, "Gray", "No", 600, 322, 400);
            arr[2] = new Train(1999, "Black", "RJD", 1000, 190, "Passagire");
            arr[3] = new Car(2022, "Red", "BMW", "Germany", 350, 2);
            arr[4] = new Airplane(2010, "Gray", "No", 600, 322, 400);
            arr[5] = new Train(1990, "Gray", "RJD", 1000, 190, "Passagire");

            foreach (var transport in arr)
                transport.Print();
        }
    }
}
