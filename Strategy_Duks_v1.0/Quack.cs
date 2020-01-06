namespace Strategy_Duks_v1_0
{
    public class Quack : IQuackBehavior
    {
        public void quack() => System.Console.WriteLine("Quack!");
    }
}