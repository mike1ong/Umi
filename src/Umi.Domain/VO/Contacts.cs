using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Values;

namespace Umi.VO
{
    public class Contacts : ValueObject
    {
        [StringLength(UmiConsts.ShortTextLength)]
        public string Name { get; set; } = string.Empty;

        [StringLength(UmiConsts.TextLength)]
        public string Email { get; set; } = string.Empty;

        [StringLength(UmiConsts.ShortTextLength)]
        public string Phone { get; set; } = string.Empty;

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Name;
            yield return Email;
            yield return Phone;
        }
    }
}
