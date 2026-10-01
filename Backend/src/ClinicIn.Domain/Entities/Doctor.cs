using ClinicIn.Entities.Bases;
using System;

namespace ClinicIn.Entities;
public class Doctor : ClinicInBaseNamedEntity
{
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public byte Gender { get; set; }
    public DateOnly? Birthdate { get; set; }
    public string? Address { get; set; }
    public int SpecialtyId { get; set; }
    public string? Title { get; set; }
}
