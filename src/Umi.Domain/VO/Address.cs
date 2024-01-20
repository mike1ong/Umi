using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Values;

namespace Umi.VO
{
    public class Address : ValueObject
    {
        [StringLength(UmiConsts.ShortTextLength)]
        public string Province { get; set; } = string.Empty;

        [StringLength(UmiConsts.ShortTextLength)]
        public string City { get; set; } = string.Empty;

        [StringLength(UmiConsts.ShortTextLength)]
        public string Region { get; set; } = string.Empty;

        [StringLength(UmiConsts.ShortTextLength)]
        public string Phone { get; set; } = string.Empty;

        [StringLength(UmiConsts.TextLength)]
        public string Street { get; set; } = string.Empty;

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Province;
            yield return City;
            yield return Region;
            yield return Phone;
            yield return Street;
        }
    }
}
