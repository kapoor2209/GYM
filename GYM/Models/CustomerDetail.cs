using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GYM.Models
{
    public class CustomerDetail
    {
        [Key]
        public int CustomerID { get; set; } // this is customer id
        public string Firstname { get; set; } // this is customer first name
        public string Lastname { get; set; } // this is customer last name
        public string DoB { get; set; } // this is customer date of birth
        public string Address { get; set; } // this is customer addresss
        public string Sex{ get; set; } // this is customer sex
    }
}
