using System;

namespace Strategy_Duks_v2_0
{
    class Program
    {
        static void Main(string[] args)
        {
            var color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($@"Study program!");
            Console.ForegroundColor = color;

            Duck mallard = new MallardDuck();
            mallard.PerformFly();
            mallard.PerformQuack();

            Duck model = new ModelDuck();
            model.PerformFly();
            model.setFlyBehavior(new FlyRocketPowered());
            model.PerformFly();

            System.Console.WriteLine();
        }
    }
}
