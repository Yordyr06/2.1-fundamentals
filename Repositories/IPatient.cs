using System;

namespace Fundamentals.Repositories 
{
  interface IPatient 
  {
    public string Name { get; set; }
    public string BirthDate { get; set; }
    public IPrescription Prescription { get; set; }
    public ITraitment Traitment { get; set; }
    public IMedicalHistory MedicalHistory { get; set; }
  }
}