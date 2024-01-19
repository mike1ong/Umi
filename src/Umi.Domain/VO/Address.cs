using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Values;

namespace Umi.VO
{
    public class Address : ValueObject
    {
        public string Province { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Region { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Addr { get; set; } = string.Empty;

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Province;
            yield return City;
            yield return Region;
            yield return PostalCode;
            yield return Country;
            yield return Phone;
            yield return Addr;
        }
    }
}
