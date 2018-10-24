using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_C_sharp_5
{
	
	abstract class Pips
	{

		public string PipClass;
		public int Health;
		abstract public double Attack(double Power);

	}

	class Elf : Pips
	{
		Random rand = new Random();
		public Elf()
		{
			PipClass = "None";
			Health = 100;
		}
		public override double Attack(double Power)
		{
			double RealAttack;
			double Percent;
			Percent = rand.Next(1, 20);
			Percent *= 0.01;
			RealAttack = Convert.ToDouble(Power) * Percent;
			Power += RealAttack;
			return Power;
		}

		public void Block(int Power)
		{
			
		}
	}
}
