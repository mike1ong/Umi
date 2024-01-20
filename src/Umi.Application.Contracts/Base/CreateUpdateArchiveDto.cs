using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Umi.Base
{
    public class CreateUpdateArchiveDto
    {
        [Required]
        [StringLength(UmiConsts.CodeLength)]
        public string Code { get; set; }

        [Required]
        [StringLength(UmiConsts.NameLength)]
        public string Name { get; set; }
        public string? AidCode { get; set; }
        public string? Description { get; set; }
    }
}
