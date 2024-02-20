namespace CarConsoleApp___Asynchronous
{
    internal class Car : CarFactory
    {
        public Car(Wheel wheel, Engine engine, CarBody carBody)
        {
            Console.WriteLine($"Creating {nameof(Car)}");
        }
    }
}
