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
			Legolas.AttPower = 86;
			Legolas.BlcPower = 20;
			

			Elf Elrond = new Elf();
			Elrond.PipClass = "Warrior";
			Elrond.Health = 672;
			Elrond.AttPower = 75;
			Elrond.BlcPower = 12;

			Console.WriteLine("Let the great battle between two elves begins!\n ----- Legolas vs Elrond -----");
			bool WhoWin;
			WhoWin = Battle.StartBattle(Legolas, Elrond);
			if(WhoWin == true)
				Console.WriteLine("Legolsd died. Elrond WIN!!!");
			else
				Console.WriteLine("Elrond died. Legolas WIN!!!");

		}
         
    }
}
