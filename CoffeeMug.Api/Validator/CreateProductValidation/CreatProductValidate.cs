using CoffeeMug.Infrastructure.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeMug.Api.Validator.CreateProductValidation
{
    public static class CreatProductValidate
    {
        public static bool Validate(CreateProduct command)
        {
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
