namespace Strategy_Adventure_v1_0
{
    public class Troll: Character
    {
        override public void Fight()
        {
            System.Console.WriteLine("Troll: ");
            if (weapon != null)
                weapon.UseWeapon();
            else 
                System.Console.WriteLine("No weapon.");
        }
    }
}