namespace Strategy_Duks_v1_0
{
    public class MuteQuack : IQuackBehavior
    {
        public void quack() => System.Console.WriteLine("<< Silence >>");
    }
}