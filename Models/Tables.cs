using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sh0pDB.Models
{
    internal class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public override string? ToString()
        {
            return $"Name  - {Name}\nEmail - {Email}\nAge   - {Age} y.o.";
        }
    }
    internal class Category
    {
        public int Id { get; set; }
        public string Type { get; set; }
    }

    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public Category Category { get; set; }
    }

    internal class Orders
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public User User { get; set; }
    }

}
