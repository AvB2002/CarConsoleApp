using System.Diagnostics;

namespace CarConsoleApp___Synchronous
{
    class Car
    {
        public Car(Wheel wheel, Engine engine, CarBody carBody)
        {
            Console.WriteLine($"Creating {nameof(Car)}");
        }
        public void CarProduced()
        {
            Console.WriteLine($"{nameof(Car)} is produced!");
        }
    }
    class CarFactory
    {
        public Engine CreateEngine()
        {
            Console.WriteLine($"Creating {nameof(Engine)}");
            Thread.Sleep(3000);
            return new Engine();
        }
        public CarBody CreateCarBody()
        {
            Console.WriteLine($"Creating {nameof(CarBody)}");
            Thread.Sleep(3000);
            return new CarBody();
        }
        public Wheel CreateWheel()
        {
            Console.WriteLine($"Creating {nameof(Wheel)}");
            Thread.Sleep(3000);
            return new Wheel();
        }
    }

    class Wheel
    {
    }

    class Engine
    {
    }

    class CarBody
    {
    }

    class Program
    {
        static async Task Main(string[] args)
        {

            Stopwatch stopwatch = Stopwatch.StartNew();

            CarFactory carFactory = new CarFactory();

            var engineTask = carFactory.CreateEngine();
            var wheelTask = carFactory.CreateWheel();
            var carBodyTask = carFactory.CreateCarBody();

            Car car = new Car(wheelTask, engineTask, carBodyTask);

            car.CarProduced();

            stopwatch.Stop();

            Console.WriteLine($"\nElapsed Time: {stopwatch.ElapsedMilliseconds} milliseconds");
        }
    }
}
