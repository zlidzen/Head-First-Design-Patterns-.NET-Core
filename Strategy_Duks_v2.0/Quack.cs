namespace Strategy_Duks_v2_0
{
    public class Quack : IQuackBehavior
    {
        public void quack() => System.Console.WriteLine("Quack!");
    }
}