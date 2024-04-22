using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Domain.Enums;

namespace WebApplication1.Domain.Entities.User
{
    public class UDbTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        [Display(Name = "Username")]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "Username cannot be longer than 30 characters.")]
        public string Username { get; set; }

        [Required]
        [Display(Name = "Password")]
        [StringLength(40, MinimumLength = 8, ErrorMessage = "Password cannot be shorter than 8 characters.")]
        public string Password { get; set; }

        [Required]
        [Display(Name  = "Email address")]
        [StringLength(30)]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        [StringLength(9, MinimumLength = 9, ErrorMessage = "Phone Number cannot be shorter than 9 characters")]
        public string PhoneNumber { get; set; }

        [DataType(DataType.Date)]
        public DateTime LastLogin { get; set; }

        [StringLength(30)]
        public string LasIp { get; set; }

        public LevelAcces Level { get; set; }
    }
}
