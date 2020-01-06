namespace Strategy_Duks_v1_0
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