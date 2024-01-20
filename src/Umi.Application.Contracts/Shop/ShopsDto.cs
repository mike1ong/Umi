using System;
using System.Collections.Generic;
using System.Text;
using Umi.Base;
using Umi.VO;

namespace Umi.Shop
{
    public class ShopsDto : ArchiveDto
    {
        public ContactsDto? Contacts { get; set; }

        public AddressDto? Address { get; set; }

        public int OrderNo { get; set; }
    }
}
