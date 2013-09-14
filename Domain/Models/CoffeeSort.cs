using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class CoffeeSort : Entity
    {
        public int Cost { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}