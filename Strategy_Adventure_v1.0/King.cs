namespace Strategy_Adventure_v1_0
{
    public class King: Character
    {
        override public void Fight()
        {
            System.Console.WriteLine("King: ");
            if (weapon != null)
                weapon.UseWeapon();
            else 
                System.Console.WriteLine("No weapon.");
        }
    }
}