namespace Strategy_Duks_v2_0
{
    public class FlyNoWay : IFlyBehavior
    {
        public void fly() => System.Console.WriteLine("I can't fly!");        
    }
}