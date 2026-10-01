using ClinicIn.Entities.Bases;


namespace ClinicIn.Entities;
public class Branch : ClinicInBaseNamedEntity
{
    public string? Address { get; set; }
    public string? Manager { get; set; }
    public string? Phone { get; set; }
    public string? Telephone { get; set; }
}
