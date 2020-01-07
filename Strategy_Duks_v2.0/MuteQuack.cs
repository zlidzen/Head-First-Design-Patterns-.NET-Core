namespace Strategy_Duks_v2_0
{
    public class MuteQuack : IQuackBehavior
    {
        public void quack() => System.Console.WriteLine("<< Silence >>");
    }
}