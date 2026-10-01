using System.ComponentModel.DataAnnotations;

namespace ClinicIn.Entities.Bases;
public class ClinicInBaseNamedEntity : ClinicInBaseEntity
{
    [Required]
    [MaxLength(ClinicInConsts.NamesMaxLength)]
    public string Name { get; set; } = string.Empty;
    public bool IsActive { get; set; }
}
