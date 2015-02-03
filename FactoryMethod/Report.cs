using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
	class Report: Document
	{
		//Factory Method implementation for this type of document
		public override void CreatePages()
		{
			Pages.Add(new IntroductionPage());
			Pages.Add(new ResultsPage());
			Pages.Add(new ConclusionPage());
			Pages.Add(new SummaryPage());
			Pages.Add(new BibliographyPage());
		}
	}
}
