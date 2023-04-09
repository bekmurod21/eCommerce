using eCommerce.Domain.Commons;
using eCommerce.Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Domain.Entities.Users
{
    public class User : Auditable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public DateTime OrderTime { get; set; }
        public PaymentType Payment { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
