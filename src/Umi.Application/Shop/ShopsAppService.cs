using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umi.Permissions;
using Umi.Shop;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Umi.Shop
{
    public class ShopsAppService : CrudAppService<Shops, ShopsDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateShopsDto>, IShopsAppService
    {
        public ShopsAppService(IRepository<Shops, Guid> repository) : base(repository)
        {
            GetPolicyName = UmiPermissions.Shops.Default;
            GetListPolicyName = UmiPermissions.Shops.Default;
            CreatePolicyName = UmiPermissions.Shops.Create;
            UpdatePolicyName = UmiPermissions.Shops.Edit;
            DeletePolicyName = UmiPermissions.Shops.Delete;
        }
    }
}
