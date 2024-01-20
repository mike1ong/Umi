using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umi.Base;
using Volo.Abp.Domain.Entities.Auditing;

namespace Umi.Shop
{
    public class ShopGroupShopList: AuditedEntity<Guid>
    {        
        public required Guid ShopGroupId { get; set; }
        public required ShopGroup ShopGroup { get; set; }

        public required Guid ShopId { get; set; }
        public required Shops Shops { get; set; }

    }
}
