using ClinicIn.Entities.Bases;
using System;
using System.Collections.Generic;

namespace ClinicIn.Entities.Patient
{
    public class Patient : ClinicInBaseNamedEntity
    {
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public byte Gender { get; set; }
        public DateOnly? Birthdate { get; set; }
        public string? Address { get; set; }
        public ICollection<PatientHabit> Habits { get; set; } = new List<PatientHabit>();
        public ICollection<PatientChronicDisease> ChronicDisease { get; set; } = new List<PatientChronicDisease>();
    }
}
