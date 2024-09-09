using System;
using System.Collections.Generic;

namespace Fundamentals.Repositories
{
  public interface IMedicalHistory
  {
    List<IAppointment> Appointment { get; set; }
    List<ITraitment> Traitment { get; set; }
    List<IPrescription> Prescription { get; set; }
  }
}