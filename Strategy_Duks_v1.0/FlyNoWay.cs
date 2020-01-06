namespace Strategy_Duks_v1_0
{
    public class FlyNoWay : IFlyBehavior
    {
        public void fly() => System.Console.WriteLine("I can't fly!");        
    }
}