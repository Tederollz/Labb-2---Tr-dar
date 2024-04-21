namespace Labb_2___Trådar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>
            {
                new Car("Car 1"),
                new Car("Car 2")
            };

            foreach (var car in cars)
            {
                Thread carThread = new Thread(car.StartRace);
                carThread.Start();
            }

            string input;
            do
            {
                Console.WriteLine("Type 'status' to get race status or press Enter to continue...");
                input = Console.ReadLine();

                if (input.ToLower() == "status")
                {
                    foreach (var car in cars)
                    {
                        Console.WriteLine($"{car.Name} is at {car.Distance} km with a speed of {car.Speed} km/h.");
                    }
                }

            } while (input.ToLower() != "exit");

            Console.WriteLine("Race ended.");
        }
    }
}
