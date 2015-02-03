using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
	class Program
	{
		static void Main(string[] args)
		{
			Document[] myDoc = new Document[2];
			myDoc[0] = new Resume();
			myDoc[1] = new Report();

			foreach (var doc in myDoc)
			{
				Console.WriteLine("\nThis is " + doc.GetType().Name +  "------\n");
				foreach (var p in doc.Pages)
				{
					Console.WriteLine("\t" + p.GetType().Name);
				}
			}

			Console.ReadLine();
		}
	}
}
