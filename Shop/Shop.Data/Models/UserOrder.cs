using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class UserOrder
    {
        public Order Order { get; set; }
        public User User { get; set; }
        public Guid OrderId { get; set; }
        public Guid UserId { get; set; }
    }
}
