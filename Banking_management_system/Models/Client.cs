using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Banking_management_system.Models
{
    public class Client : User
    {
        public bool Approved { get; set; }
        public string BankName { get; set; }
        public string CompanyName { get; set; }
        public ICollection<Balance> Balances { get; set; }
        public ICollection<Credit> Credits { get; set; }
        public ICollection<Deposit> Deposit { get; set; }
        public ICollection<Installment> Installments { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DataType CurrentTime { get; set; }
        public float Percentage { get; set; }
        public bool Salary { get; set; }
    }
}
