using ClinicIn.Entities.Bases;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicIn.Entities.Patient;
public class PatientHabit : ClinicInBaseEntity
{
    public int PatientId { get; set; }
    public int HabitTypeId { get; set; }
    public int HabitStatusId { get; set; }
    public string? Notes { get; set; }

    [ForeignKey(nameof(PatientId))]
    public Patient? Patient{ get; set; }
}
