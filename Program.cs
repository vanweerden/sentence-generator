using System;
using System.Collections.Generic;

namespace SentenceGenerator
{
  class Program
  {
    static void Main(string[] args)
    {
      var verbs = new List<Verb>();
      verbs.Add(new Verb("miss"));
      verbs.Add(new Verb("write"));
      verbs.Add(new Verb("have"));

      foreach (Verb verb in verbs)
        Console.WriteLine(verb.ThirdPerson);
    }
  }
}
