namespace Strategy_Adventure_v1_0
{
    abstract public class Character
    {
        public IWeaponBehavior weapon;
        abstract public void Fight();
        public void SetWeapon(IWeaponBehavior w)
        {
            this.weapon = w;
        }
    }
}