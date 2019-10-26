using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoffeeMug.Core.Domain
{
    public class Product : Entity
    {
        [StringLength(100)]
        public string Name { get; protected set; }

        public decimal Price { get; protected set; }

        public Product(Guid Id, string Name, decimal Price)
        {
            base.Id = Id;
            this.Name = Name;
            this.Price = Price;
        }

        public void SetName(string Name)
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                throw new Exception($"Event: {this.Id} cannot have an empty name!");
            }

            this.Name = Name;
        }

        public void SetPrice(decimal Price)
        {
            if(Price < 0)
            {
                throw new Exception($"Event: {this.Id} cannot have price less than '0'!");
            }
            this.Price = Price;
        }
    }
}