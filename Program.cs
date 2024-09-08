using System;

namespace Fundamentals
{
  class Appointment 
  {
    public string date;
    public string patient;
    public void Impending() 
    {
      Console.Beep(3000, 1000);
    }
  }
  class Program 
  {
    static void Main(string[] args)
    {
      var myAppointment = new Appointment();
      myAppointment.Impending();
      Console.WriteLine("Hello, World!");
    }
  }
}