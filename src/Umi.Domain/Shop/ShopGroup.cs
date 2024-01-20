using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umi.Base;

namespace Umi.Shop
{
    public class ShopGroup: ArchiveEntity
    {
        [DefaultValue(1000)]
        public int OrderNo { get; set; }

        public int ShopCount { get; set; }

        public ICollection<ShopGroupShopList> ShopList { get; set; } = new List<ShopGroupShopList>();
    }
}
