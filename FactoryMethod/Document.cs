using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
	abstract class Document
	{
		private List<Page> _myPages = new List<Page>();

		public Document()
		{
			this.CreatePages();
		}

		public List<Page> Pages
		{
			get { return _myPages; }
		}

		//Factory Method
		public abstract void CreatePages();
	}
}
