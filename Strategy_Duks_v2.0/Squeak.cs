namespace Strategy_Duks_v2_0
{
    public class Squeak : IQuackBehavior
    {
        public void quack() => System.Console.WriteLine("Squeak!");
    }
}