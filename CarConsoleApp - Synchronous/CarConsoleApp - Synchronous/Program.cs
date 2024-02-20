using System.Diagnostics;

namespace CarConsoleApp___Synchronous
{
    internal class Program
    {
        static void Main(string[] args)
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
