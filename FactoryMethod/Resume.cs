using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
	class Resume: Document
	{
		public override void CreatePages()
		{
			Pages.Add(new SkillPage());
			Pages.Add(new EducationPage());
			Pages.Add(new ExperiencePage());
		}
	}
}
