namespace Reference.Framework.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("User")]
    public class User
    {
        [Key]
        public int UserId { get; set; }

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
        public string PasswordHash { get; set; }

        [Required]
        [StringLength(500)]
        public string Salt { get; set; }

        [Required]
        public int GenderId { get; set; }

        [Required]
        public DateTime DOB { get; set; }

        [Required]
        public bool IsDeleted { get; set; }

        public virtual LuGender LuGender { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
