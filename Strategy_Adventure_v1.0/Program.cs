using System;

namespace Strategy_Adventure_v1_0
{
    class Program
    {
        static void Main(string[] args)
        {
            Character q = new Queen();
            q.SetWeapon(new KnifeBehavior());
            q.Fight();
            q.SetWeapon(new AxeBehavior());
            q.Fight();

            Console.WriteLine();
        }
    }
}
