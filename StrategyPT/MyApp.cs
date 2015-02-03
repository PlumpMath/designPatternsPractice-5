using System;

namespace StrategyPT
{
	class MyApp
	{
		static void Main(string[] args)
		{
			Console.Write("=== Lets Start ===\n[y/n]");
			string response = Console.ReadLine();

			if (response.ToLower() == "y")
			{
				Context _context;

				//Get my 'A' Strategy
				_context = new Context(new ConcreteStrategyA());

				if (_context != null)
				{
					_context.DoTheActionForThisStrategy();
				}

				//Get my 'B' Strategy
				_context = new Context(new ConcreteStrategyB());
				if (_context != null)
				{
					_context.DoTheActionForThisStrategy();
				}

				//Get my 'C' Strategy
				_context = new Context(new ConcreteStrategyC());
				if (_context != null)
				{
					_context.DoTheActionForThisStrategy();
				}
			}
			else 
			{
				Console.ReadLine();
			}
		}
	}
}
