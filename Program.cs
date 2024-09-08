using System;
using Fundamentals.Repositories;

namespace Fundamentals
{
  class Program 
  {
    static void Main(string[] args)
    {
      var myPatient = new Patient();
      myPatient.Name = "John Doe";
      Console.WriteLine(myPatient.Name);
    }
  }
}