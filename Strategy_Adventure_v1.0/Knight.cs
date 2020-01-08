namespace Strategy_Adventure_v1_0
{
    public class Knight: Character
    {
        override public void Fight()
        {
            System.Console.WriteLine("Knight: ");
            if (weapon != null)
                weapon.UseWeapon();
            else 
                System.Console.WriteLine("No weapon.");
        }
    }
}