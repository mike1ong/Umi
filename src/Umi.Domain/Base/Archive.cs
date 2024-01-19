using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Umi.Base
{
    public class Archive: FullAuditedAggregateRoot<Guid>
    {
        [Required]
        [StringLength(UmiConsts.CodeLength)]
        public required string Code { get; set; }

        [Required]
        [StringLength(UmiConsts.NameLength)]
        public required string Name { get; set; }

        [StringLength(UmiConsts.CodeLength)]
        public string? AidCode { get; set; }

        [StringLength(UmiConsts.TextLength)]
        public string? Description { get; set; }

    }
}
