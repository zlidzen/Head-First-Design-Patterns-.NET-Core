namespace Strategy_Adventure_v1_0
{
    public class AxeBehavior : IWeaponBehavior
    {
        public void UseWeapon()
        {
            System.Console.WriteLine("Swinging an ax!");
        }
    }
}