using System.Diagnostics;

namespace CarConsoleApp___Asynchronous
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
        public async Task<Engine> CreateEngine()
        {
            Console.WriteLine($"Creating {nameof(Engine)}");
            await Task.Delay(3000);
            return new Engine();
        }
        public async Task<CarBody> CreateCarBody()
        {
            Console.WriteLine($"Creating {nameof(CarBody)}");
            await Task.Delay(3000);
            return new CarBody();
        }
        public async Task<Wheel> CreateWheel()
        {
            Console.WriteLine($"Creating {nameof(Wheel)}");
            await Task.Delay(3000);
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

            Car car = new Car(await wheelTask, await engineTask, await carBodyTask);

            car.CarProduced();

            stopwatch.Stop();

            Console.WriteLine($"\nElapsed Time: {stopwatch.ElapsedMilliseconds} milliseconds");
        }
    }
}
