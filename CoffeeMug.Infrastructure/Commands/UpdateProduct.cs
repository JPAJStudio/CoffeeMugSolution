using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMug.Infrastructure.Commands
{
    //PID - != null
    //PN - krotsza niz 100, nie pusta
    //PP - wieksza niz 0
    public class UpdateProduct
    {
        public Guid ProductId { get; set; }

        public string ProductName { get; set; }

        public decimal ProductPrice { get; set; }
    }
}
