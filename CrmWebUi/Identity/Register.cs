using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrmWebUi.Identity
{
    public class Register
    {
        public int Id { get; set; }
       
        public string userName { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email{get;set;}
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string rePassword { get; set; }
    }
}
