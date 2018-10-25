using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_C_sharp_5
{

	abstract class Pips
	{

		public string PipClass;
		public int Health;
		public double AttPower;
		public double BlcPower;
		abstract public double Attack(double Power);

	}

	class Elf : Pips
	{
		Random rand = new Random();

		public Elf()
		{
			PipClass = "None";
			Health = 100;
			AttPower = 0;
			BlcPower = 0;
		}
		public override double Attack(double AttPower)
		{
			double RealAttack, Percent;
			Percent = rand.Next(1, 20) * 0.01;
			RealAttack = Convert.ToDouble(AttPower) * Percent;
			AttPower += RealAttack;
			return AttPower;
		}

		public double Block(double BlcPower)
		{
			double RealAttack, Percent;
			Percent = rand.Next(1, 13) * 0.01;
			RealAttack = Convert.ToDouble(BlcPower) * Percent;
			BlcPower += RealAttack;
			return BlcPower;
		}
	}
}
