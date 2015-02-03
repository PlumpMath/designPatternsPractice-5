using System;

namespace StrategyPT
{
	class ConcreteStrategyA: Strategy
	{
		public override void ActionToPerform()
		{
			//Do something for the Action A ...
			Console.WriteLine("Execture from Concrete Strategy A...");
		}
	}
}
