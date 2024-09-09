namespace Fundamentals.Repositories
{
  interface ITraitment
  {
    public int Id { get; protected set; }
    public IDate Date { get; set; }
    public string Duration { get; set; }
    public string Description { get; set; }
    // public Patient Patient { get; set; }
    public IPrescription Prescription { get; set; }
    public ClinicalProcedure Procedure { get; set; }
    public IMedicalHistory UpdateMedicalHistory()
    {
      return ;
      // TO DO: Implement Print method
    }
  }
}
