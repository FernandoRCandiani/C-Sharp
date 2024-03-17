using Figuras.Model.Entities;
using Figuras.Model.Enums;


namespace Figuras
{
    class Program
    {
        static void Main(string[] args)
        {

           IShape s1 = new Circle() { Radius = 2.0, color = Color.White };
           IShape s2 = new Rectangle() { width = 3.5, height = 4.2, color = Color.Black };

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}