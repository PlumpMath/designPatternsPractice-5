using ConAppDesignPaterns;
using System;

namespace Singleton
{
	class MyApp
	{
		static void Main(string[] args)
		{
			Run();
		}

		private static void Run()
		{
			//this is not a thread safe ...
			MySingleton ms1 = MySingleton.GetObj();
			ms1.Print("This is printed from inside mySingleton class print method...\n");
			
			ms1.Print("I am called from: " + ms1.GetType().Name);
			Console.ReadLine();
		}
	}
}
