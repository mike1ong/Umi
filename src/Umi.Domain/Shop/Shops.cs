using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umi.Base;
using Umi.VO;

namespace Umi.Shop
{
    public class Shops : Archive
    {
        public Contacts? Contacts { get; set; }

        public Address? Address { get; set; }

        [DefaultValue(1000)]
        public int OrderNo { get; set; }
    }
}
