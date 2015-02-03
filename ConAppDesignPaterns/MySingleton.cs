using System;

namespace ConAppDesignPaterns
{
	class MySingleton: IPrint
	{
		protected static MySingleton _obj;

		private MySingleton() { }

		public static MySingleton GetObj()
		{
			if (_obj == null)
			{
				_obj = new MySingleton();
			}
			return _obj;
		}

		public void Print(string s)
		{
			Console.WriteLine(s);
		}
	}
}
