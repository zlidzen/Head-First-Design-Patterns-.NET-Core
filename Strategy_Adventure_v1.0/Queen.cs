namespace Strategy_Adventure_v1_0
{
    public class Queen: Character
    {
        override public void Fight()
        {
            System.Console.WriteLine("Queen: ");
            if (weapon != null)
                weapon.UseWeapon();
            else 
                System.Console.WriteLine("No weapon.");
        }
    }
}