using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Identity;

namespace ClinicIn.Entities.Bases;
public class ClinicInBaseEntity : FullAuditedEntityWithUser<int, IdentityUser>;


