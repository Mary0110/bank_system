using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banking_management_system.Models
{
    public class Company
    {
        public int ID { get; set; }
        public int BIC { get; set; }
        public int BankID { get; set; }
        public string Adress { get; set; }
        public string Name { get; set; }
        public float Percentage { get; set; }
        public int PIN { get; set; }
        public float SalaryAccount { get; set; }
        public string Type { get; set; }
    }
}
