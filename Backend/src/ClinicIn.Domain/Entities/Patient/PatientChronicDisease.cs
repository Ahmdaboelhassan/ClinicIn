using ClinicIn.Entities.Bases;
using ClinicIn.Enums.Patient;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Identity;

namespace ClinicIn.Entities.Patient;
public class PatientChronicDisease : ClinicInBaseEntity
{
    public int PatientId { get; set; }
    public int DiseaseId { get; set; }
    public string? Notes { get; set; }

    [ForeignKey(nameof(PatientId))]
    public Patient? Patient { get; set; }
}
