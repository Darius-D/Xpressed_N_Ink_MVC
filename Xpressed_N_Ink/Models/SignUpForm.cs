using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Xpressed_N_Ink.Models
{
    public class SignUpForm
    {
        [Required(ErrorMessage = "Name Require. This will not be visible or shared with others.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Name Require.This will not be visible or shared with others.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Alias Required. This will be visible to others.")]
        public string Alias { get; set; }

        [Required(ErrorMessage = "Email Required. This will not be shared with any third party.")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Name Require.This will not be visible or shared with others")]
        [PasswordPropertyText]
        public string Password { get; set; }

    }
}
