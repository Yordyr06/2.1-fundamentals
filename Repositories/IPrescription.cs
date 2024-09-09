namespace Fundamentals.Repositories
{
  interface IPrescription 
  {
    public int Id { get; set; }
    public IDate Date { get; set; }
    public string Description { get; set; }
    // public Patient IPatient { get; set; }
    
    public IMedicalHistory UpdateMedicalHistory()
    {
      return ;
      // TO DO: Implement Print method
    }
  }
}