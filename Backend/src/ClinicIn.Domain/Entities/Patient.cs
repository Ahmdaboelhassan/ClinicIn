using Volo.Abp.Domain.Entities.Auditing;

namespace ClinicIn.Entities
{
    public class Patient : FullAuditedEntity<int>
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }




    }
}
