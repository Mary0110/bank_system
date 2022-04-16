using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banking_management_system.Models
{
    public class Balance
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int ClientID { get; set; }
        public float Money { get; set; }
    }
}
