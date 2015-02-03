using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPT
{
	class ConcreteStrategyB: Strategy
	{
		public override void ActionToPerform()
		{
			//Do something for Action B...
			Console.WriteLine("Executed from Concrete Strategy B...");
		}
	}
}
