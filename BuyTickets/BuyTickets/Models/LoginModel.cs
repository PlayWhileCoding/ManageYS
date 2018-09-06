using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BuyTickets.Models
{
    public class LoginModel
    {        
        [DataType(DataType.EmailAddress)]  
        [Required(ErrorMessage ="Nickname is required")]
        [Display(Name ="Nickname")]
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage ="Secret word required")]
        [Display(Name = "Your secret word")]
        public string Password { get; set; }

    }
}