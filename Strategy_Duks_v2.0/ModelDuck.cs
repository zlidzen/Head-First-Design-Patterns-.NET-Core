namespace Strategy_Duks_v2_0
{
    public class ModelDuck: Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Quack();
        }

        override public void Display() => System.Console.WriteLine("I'm model duck!");        
    }
}