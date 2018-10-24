using System;

namespace OOP_C_sharp_5
{
    class Program
    {
        static void Main(string[] args)
        {
			Elf Legolas=new Elf();
			Legolas.PipClass = "Archer";
			Legolas.Health = 486;
			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine(Convert.ToInt32(Legolas.Attack(86)));
			}

			Elf Elrond = new Elf();
			Elrond.PipClass = "Warrior";
			Elrond.Health = 672;
			
        }
         
    }
}
