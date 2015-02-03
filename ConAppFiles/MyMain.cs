using System;
using System.Configuration;

namespace ConAppFiles
{
	class MyMain
	{
		static void Main(string[] args)
		{
			Run();
			Console.ReadLine();
		}

		/// <summary>
		/// Static method to call into Helper file
		/// it uses App.config to get resources
		/// </summary>
		public static void Run()
		{
			string fileName = ConfigurationManager.AppSettings["myFileName"];
			
			Helper h1 = new Helper();
			if (!String.IsNullOrEmpty(fileName))
			{
				h1.Open(fileName);
			}
			else
			{
				h1.Print("There is something wrong with you Resource file, please check...");
			}
		}
	}
}
