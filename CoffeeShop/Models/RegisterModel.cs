﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CoffeeShop.Models
{
    public class RegisterModel
    {
        [Required]
        [MaxLength(50, ErrorMessage = "Please limit your first name to 50 characters")]
        [DisplayName("First name")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Please limit your last name to 50 characters")]
        [DisplayName("Last name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please select one!")]
        public Gender UserGender { get; set; }

        [Required]
        [RegularExpression(@"^[\w -\.] +@([\w -] +\.)+[\w-]{2,4}$", ErrorMessage = "Please enter a valid email")]
        [DisplayName("Email")]
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"^\(?([2-9][0-8][0-9])\)?[-.●]?([2-9][0-9]{2})[-.●]?([0-9]{4})$", ErrorMessage ="Please enter a valid email in the form xxx-xxx-xxxx")]
        [DisplayName("Phone number")]
        public string PhoneNumber { get; set; }        
    }
        public enum Gender
        {
            Female,
            Male,
            Other
        }

}