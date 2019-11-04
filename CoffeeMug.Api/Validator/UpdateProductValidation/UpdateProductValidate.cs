using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeMug.Infrastructure.Commands;

namespace CoffeeMug.Api.Validator.UpdateProductValidation
{
    public class UpdateProductValidate
    {
        public static bool Validate(UpdateProduct command)
        {
            if (command.ProductId == Guid.Empty)
                return false;

            if (string.IsNullOrEmpty(command.ProductName))
                return false;

            if (command.ProductName.Length > 100)
                return false;

            if (command.ProductPrice <= 0)
                return false;

            return true;
        }
    }
}
