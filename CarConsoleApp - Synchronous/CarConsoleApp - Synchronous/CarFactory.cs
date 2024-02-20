namespace CarConsoleApp___Synchronous
{
    internal class CarFactory
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
}
