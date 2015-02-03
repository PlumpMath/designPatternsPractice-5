using System;

namespace StrategyPT
{
	public class ConcreteStrategyC: Strategy
	{
		public override void ActionToPerform()
		{
			//Do something for Action C ...
			Console.WriteLine("Executed from Concrete Strategy C ...");
		}
	}
}
