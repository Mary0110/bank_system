using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Banking_management_system.Models
{
    public class Installment
    {
        public int ID { get; set; }
        public bool Approved { get; set; }
        [DataType(DataType.Date)]
        public DataType OpenedTime { get; set; }
        public DataType ClosedTime { get; set; }
        public int TotalMonths { get; set; }
        public int ClientID { get; set; }
        public float Money { get; set; }
        public float MoneyPaid { get; set; }
        public int MonthsPassed { get; set; }
    }
}
