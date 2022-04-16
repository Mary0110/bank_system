using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banking_management_system.Models
{
    public class Salary
    {
        public int ID { get; set; }
        public bool ApprovedByOperator { get; set; }
        public bool ApprovedBySpecialist { get; set; }
        public int ClientID { get; set; }
        public float Money { get; set; }

    }
}
