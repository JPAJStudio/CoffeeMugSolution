using AutoMapper;
using CoffeeMug.Core.Domain;
using CoffeeMug.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeMug.Infrastructure.Mappers
{
    public static class AutoMapperConfig
    {
        public static IMapper Initailize()
            => new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Product, ProductDTO>();

            })
            .CreateMapper();
    }
}
