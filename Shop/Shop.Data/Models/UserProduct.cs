using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class UserProduct
    {
        public Product Product { get; set; }
        public User User { get; set; }
        public Guid ProductId { get; set; }
        public Guid UserId { get; set; }
    }
}
