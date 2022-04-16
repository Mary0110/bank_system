using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banking_management_system.Models
{
    public class Bank
    {
        public int ID { get; set; }
        public string BIC { get; set; }
        public string Name { get; set; }
        public float Percentage { get; set; }
    }
}

