using System;

namespace Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            
            if(projection == "Premiere")
            {
                Console.WriteLine($"{12 * rows * columns:f2} leva");
            }else if(projection == "Normal")
            {
                Console.WriteLine($"{7.50 * rows * columns:f2} leva");
            }
            else
            {
                Console.WriteLine($"{5 * rows * columns:f2} leva");
            }
        }
    }
}
