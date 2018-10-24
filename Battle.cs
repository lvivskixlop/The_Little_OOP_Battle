using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_C_sharp_5
{
	static class Battle
	{
		public static bool StartBattle(Elf Man0, Elf Man1)
		{
			while (true)
			{
				Man0.Health -= (Convert.ToInt32(Man1.AttPower) - Convert.ToInt32(Man0.BlcPower));
				Console.WriteLine("\nElrond hit Legolas with {0} damage. Legolas blocked {1}. Legolas get {2} damage", Man1.AttPower, Man0.BlcPower, Man1.AttPower- Man0.BlcPower);
				Console.WriteLine("Legolas health: {0}", Man0.Health);
				if(Man0.Health < 1)
				{
					return true;
				}
				Man1.Health -= (Convert.ToInt32(Man0.AttPower) - Convert.ToInt32(Man1.BlcPower));
				Console.WriteLine("\nLegolass hit Elrond with {0} damage. Elrond blocked {1}. Elrond get {2} damage", Man0.AttPower, Man1.BlcPower, Man0.AttPower - Man1.BlcPower);
				Console.WriteLine("Elrond health: {0}", Man1.Health);
				if (Man1.Health < 1)
				{
					return false;
				}
				Console.Write("\nPress any key to continiue that bloody fight!");
				Console.ReadKey();
			}
		}
	}
}
