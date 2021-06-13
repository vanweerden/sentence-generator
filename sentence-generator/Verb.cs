using System;

namespace SentenceGenerator
{
	public class Verb : Word
	{
		public Verb(string baseForm)
		{
			Base = baseForm;
		}

		public string Ing {
			get {
				string ingForm = Base;
				if (WordEndsCe())
					ingForm = RemoveLastLetter() + "ing";
				else if (WordEndsCVC())
					ingForm = DoubleLastLetter() + "ing";
				else
					ingForm = Base + "ing";
				return ingForm;
			}
		}
		public string Past
		{
			get
			{
				string pastForm;
				if (IsIrregular())
					pastForm = GetIrregularPastForm();
				else if (WordEndsCVC())
					pastForm = DoubleLastLetter() + "ed";
				else if (LastLetter == 'e')
					pastForm = Base + 'd';
				else
					pastForm = Base + "ed";	
				return pastForm;
			}
		}
		public string PastParticiple
		{
			get
			{
				string pp;
				if (IsIrregular())
					pp = GetIrregularPastParticipleForm();
				else if (WordEndsCVC())
					pp = DoubleLastLetter() + "ed";
				else if (LastLetter == 'e')
					pp = Base + 'd';
				else
					pp = Base + "ed";
				return pp;
			}
		}
		public string ThirdPerson
    {
			get
			{
				string thirdPersonForm;
				if (Base == "have")
					thirdPersonForm = "has";
				else if (LastLetter == 's')
					thirdPersonForm = Base + "es";
				else
					thirdPersonForm = Base + 's';
				return thirdPersonForm;
			}
		}

		private bool IsIrregular()
    {
			bool result = Constants.IrregularVerbForms.ContainsKey(Base);
			return result;
		}
		private string GetIrregularPastForm()
    {
			string irregularForm = Constants.IrregularVerbForms[Base].Past;
			return irregularForm;
    }
		private string GetIrregularPastParticipleForm()
		{
			string irregularForm = Constants.IrregularVerbForms[Base].PastParticiple;
			return irregularForm;
		}
	}
}

