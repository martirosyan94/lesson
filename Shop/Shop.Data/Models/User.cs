using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public Guid SecretId { get; set; }
        public bool IsAdmin { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public IEnumerable<UserOrder> UserOrders { get; set; } = new HashSet<UserOrder>();
        public IEnumerable<UserProduct> UserProducts { get; set; } = new HashSet<UserProduct>();

    }
}
