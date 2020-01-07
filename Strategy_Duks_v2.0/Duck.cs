namespace Strategy_Duks_v2_0
{
     public abstract class Duck
    {
        public IFlyBehavior flyBehavior;
        public IQuackBehavior quackBehavior;
        public abstract void Display();
        public void PerformFly()
        {
            flyBehavior.fly();
        }
        public void PerformQuack()
        {
            quackBehavior.quack();
        }
        public void Swim()
        {
            System.Console.WriteLine("All ducks float, even decoys!");
        }
        public void setFlyBehavior(IFlyBehavior fb)
        {
            flyBehavior = fb;
        }
        public void setQuackBehavior(IQuackBehavior qb)
        {
            quackBehavior = qb;
        }
        
    }
}