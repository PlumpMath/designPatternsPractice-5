using System;
using System.IO;
using System.Configuration;


namespace ConAppFiles
{
	class Helper: IPrint
	{
		public int Count { get; set; }

		public bool Open(string fileName)
		{
			string dir =ConfigurationManager.AppSettings["localPath"];

			try
			{
				using (StreamReader sr = new StreamReader(dir + fileName))
				{
					string line = String.Empty;

					while ((line = sr.ReadLine()) != null)
					{
						line = line.Trim();
						if (line.Contains("From:"))
						{
							Print(line);
							Count += 1;
						}
					}
				}
			}
			catch (FileNotFoundException ex)
			{
				Print(ex.Message);
			}

			Print("\n" + Count.ToString());
			return true;
		}

		public void Print(string line)
		{
			Console.WriteLine(line);
		}
	}
}
