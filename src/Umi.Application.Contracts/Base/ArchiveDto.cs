﻿using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Umi.Base
{
    public class ArchiveDto : FullAuditedEntityDto<Guid>
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        
        public string? AidCode { get; set; }
        public string? Description { get; set; }
    }
}
