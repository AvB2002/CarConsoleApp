namespace CarConsoleApp___Synchronous
{
    internal class Car : CarBody
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
}
