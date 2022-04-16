using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banking_management_system.Models
{
    public class Specialist : User
    {   
        public int CompanyID { get; set; }
        public ICollection<Balance> Balances{ get; set; }
    }
}
