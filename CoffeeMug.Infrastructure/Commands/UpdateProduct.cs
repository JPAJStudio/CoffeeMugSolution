using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMug.Infrastructure.Commands
{
    public class UpdateProduct
    {
        public Guid ProductId { get; set; }

        public string ProductName { get; set; }

        public decimal ProductPrice { get; set; }
    }
}
