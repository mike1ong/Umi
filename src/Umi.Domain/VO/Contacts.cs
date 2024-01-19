using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Values;

namespace Umi.VO
{
    public class Contacts : ValueObject
    {
        public string ContactName { get; set; } = string.Empty;
        public string ContactEmail { get; set; } = string.Empty;
        public string ContactPhone { get; set; } = string.Empty;

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return ContactName;
            yield return ContactEmail;
            yield return ContactPhone;
        }
    }
}
