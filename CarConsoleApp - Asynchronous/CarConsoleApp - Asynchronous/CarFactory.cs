using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConsoleApp___Asynchronous
{
    internal class CarFactory
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
        public void CarProduced()
        {
            Console.WriteLine($"{nameof(Car)} is produced!");
        }
    }
}
