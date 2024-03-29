﻿using AutoMapper;
using Umi.Shop;

namespace Umi;

public class UmiApplicationAutoMapperProfile : Profile
{
    public UmiApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Shops, ShopsDto>();
        CreateMap<CreateUpdateShopsDto, Shops>();
    }
}
