using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeMug.Infrastructure.Commands
{
    public class CreateProduct
    {
        public string ProductName { get; set; }

        public decimal ProductPrice { get; set; }
    }
}
