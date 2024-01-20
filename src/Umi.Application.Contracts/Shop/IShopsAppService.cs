using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Umi.Shop
{
    public interface IShopsAppService: ICrudAppService<ShopsDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateShopsDto>
    {
    }
}
