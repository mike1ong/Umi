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
        public required string Code { get; set; }
        public required string Name { get; set; }
        public string? AidCode { get; set; }
        public string? Description { get; set; }

    }
}
