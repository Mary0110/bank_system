using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Banking_management_system.Models
{
    public class User
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string Surname { get; set; }
        [StringLength(50)]
        public string Patronic { get; set; }

        [Required]
        [MaxLength(80)]
       // [IsUnicode(false)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordSeries { get; set; }
        public int Phone { get; set; }
        public int PasswordNumber { get; set; }
    }
}
