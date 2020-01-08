namespace Strategy_Adventure_v1_0
{
    public class BowAndArrowBehavior : IWeaponBehavior
    {
        public void UseWeapon()
        {
            System.Console.WriteLine("Shot by arrow!");
        }
    }
}