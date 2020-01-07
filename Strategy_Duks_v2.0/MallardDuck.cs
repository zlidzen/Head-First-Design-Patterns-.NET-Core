namespace Strategy_Duks_v2_0
{
    public class MallardDuck: Duck
    {
        public MallardDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings(); 
        }

        override public void Display() => System.Console.WriteLine("I'm real Mallard duck!");
    }
}