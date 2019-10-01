using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car();
            c1.Make = "Ford";
            c1.Model = "Focus";
            c1.CurrentSpeed = 0;
            c1.EngineSize = 1.6;

            Car c2 = new Car();
            c1.Make = "Opel";
            c1.Model = "Astra";
            c1.CurrentSpeed = 0;
            c1.EngineSize = 1.2;

            //WriteLine($"The {c1.Make}")
        }
    }
    class Car
    {

    }
}
