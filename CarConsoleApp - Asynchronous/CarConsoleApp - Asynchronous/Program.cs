using System.Diagnostics;

namespace CarConsoleApp___Asynchronous
{
    internal class Program
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
