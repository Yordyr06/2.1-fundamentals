using System;

namespace Fundamentals.Repositories 
{
  interface IAppointment 
  {
    public int Id { get; set; }
    public IPatient Patient { get; set; }
    public IDate Date { get; set; }
    public Workday Workday { get; set; }
    public Schedule Schedule { get; set; }
    public void Impending() 
    {
      // TO DO: Implement Impending method
    }    
  }
}