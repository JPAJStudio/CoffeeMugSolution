using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeMug.Infrastructure.Commands
{
    //PN - niepusty, krotszy niz 100
    //PP - wieksza od 0
    public class CreateProduct
    {
        public string ProductName { get; set; }

        public decimal ProductPrice { get; set; }
    }
}
