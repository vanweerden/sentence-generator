using System;
using System.Text.RegularExpressions;

namespace SentenceGenerator
{

  // TODO: Change this class name
  abstract public class Word
  {
    protected string Base;
    protected char LastLetter
    {
      get
      {
        return Base[Base.Length - 1];
      }
    }
    protected bool WordEndsCVC()
    {
      Regex cvcRegex = new Regex(@"^\w*[^aeiou][aeiuo][^aeiouyw]$");
      return cvcRegex.IsMatch(Base);
    }
    // Word ends consonant + 'e'
    protected bool WordEndsCe()
    {
      Regex ceRegex = new Regex(@"^\w+[^aeiou]e$");
      return ceRegex.IsMatch(Base);
    }
    protected string DoubleLastLetter()
    {
      string doubled = Base + LastLetter;
      return doubled;
    }
    protected string RemoveLastLetter()
    {
      string removed = Base.Substring(0, Base.Length - 1);
      return removed;
    }
  }
}
