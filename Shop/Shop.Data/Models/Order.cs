using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Decimal Cost { get; set; }
        public IEnumerable<ProductOrder> ProductOrders { get; set; } = new HashSet<ProductOrder>();
    }
}
