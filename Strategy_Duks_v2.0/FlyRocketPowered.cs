namespace Strategy_Duks_v2_0
{
    public class FlyRocketPowered : IFlyBehavior
    {
        public void fly()
        {
            System.Console.WriteLine("I'm flying with a rocket!");
        }
    }
}