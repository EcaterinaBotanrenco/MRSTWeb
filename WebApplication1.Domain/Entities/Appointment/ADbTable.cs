using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Domain.Entities.Appointment
{
    public class ADbTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Required]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Enter Name")]
        [Display(Name = "Name")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Name cannot be longer that 20 characters.")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Select Service")]
        [Display(Name = "Username")]
        public string Service { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email adress")]
        [StringLength(30)]
        public string Email { get; set; }

        [DataType(DataType.DateTime)]
        public Nullable<DateTime> AppointmentDate { get; set; }
    }
}
