namespace Reference.Framework.Web.ViewModels
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class UserViewModel
    {
        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(500)]
        public string Password { get; set; }

        [Required]
        public int GenderId { get; set; }

        [Required]
        public DateTime DOB { get; set; }
    }
}