using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPT
{
	class Context
	{
		private Strategy _strategy;

		public Context(Strategy myStrategy)
		{
			_strategy = myStrategy;
		}

		public void DoTheActionForThisStrategy()
		{
			_strategy.ActionToPerform();
		}
	}
}
