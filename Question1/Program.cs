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
            c2.Make = "Opel";
            c2.Model = "Astra";
            c2.CurrentSpeed = 0;
            c2.EngineSize = 1.2;

            WriteLine($"The {c1.Make} {c1.Model}, Engine size: {c1.EngineSize}l is currently travelling at {c1.CurrentSpeed} km/h");

            WriteLine($"The {c2.Make} {c2.Model}, Engine size: {c2.EngineSize}l is currently travelling at {c2.CurrentSpeed} km/h");
        }
    }
    class Car
    {
        private string _make;

        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }
        private string _model;
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        private int _currentSpeed;
        public int CurrentSpeed
        {
            get { return _currentSpeed;}
            set { _currentSpeed = value; }
        }
        private double _enginSize;

        public double EngineSize
        {
            get { return _enginSize; }
            set { _enginSize = value; }
        }
    }
}
