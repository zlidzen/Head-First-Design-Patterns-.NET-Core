namespace Strategy_Adventure_v1_0
{
    public class KnifeBehavior : IWeaponBehavior
    {
        public void UseWeapon()
        {
            System.Console.WriteLine("Throw 3 knives!");
        }
    }
}