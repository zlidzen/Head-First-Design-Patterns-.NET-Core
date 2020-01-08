namespace Strategy_Adventure_v1_0
{
    public class SwordBehavior : IWeaponBehavior
    {
        public void UseWeapon()
        {
            System.Console.WriteLine("Chop by sword!");
        }
    }
}