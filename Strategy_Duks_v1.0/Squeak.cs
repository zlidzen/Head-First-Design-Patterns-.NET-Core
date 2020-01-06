namespace Strategy_Duks_v1_0
{
    public class Squeak : IQuackBehavior
    {
        public void quack() => System.Console.WriteLine("Squeak!");
    }
}