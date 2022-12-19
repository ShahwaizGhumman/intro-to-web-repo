using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Car_Rental_System.Models
{
    public class DataModel
    {
        [Key]
        [Required]
        [Display(Name = "Customer Id")]
        public int StdId { get; set; }
        [Column(TypeName = "varchar(50)")]
        [Required]
        [Display(Name = "First-Name ")]
        [StringLength(maximumLength: 35, MinimumLength = 5, ErrorMessage = "Username must have max length 35 and min length 5")]
        public string FirstName { get; set; }
        [Column(TypeName = "varchar(150)")]
        [Required]
        [Display(Name = "Last-Name ")]
        [StringLength(maximumLength: 35, MinimumLength = 5, ErrorMessage = "Username must have max length 35 and min length 5")]
        public string LastName { get; set; }
        [Column(TypeName = "varchar(150)")]
        [Required]
        [Display(Name = "Name of the Father/Guardian")]
        [StringLength(maximumLength: 35, MinimumLength = 5, ErrorMessage = "Username must have max length 35 and min length 5")]
        public string FName { get; set; }
        [Column(TypeName = "varchar(150)")]
        [Required]
        [Display(Name = "Age ")]
        public DateTime Age { get; set; }

        [Required]
        [Display(Name = "E-Mail")]
        [EmailAddress(ErrorMessage = "Enter the proper Email Address !")]
        public string E_Mail { get; set; }
        [Column(TypeName = "varchar(250)")]

        [Required]
        [Display(Name = "Contact Number")]
        public int Ctcno { get; set; }
        [Required]
        [Display(Name = "National CNIC")]
        [StringLength(13, MinimumLength = 13, ErrorMessage = "Enter the CNIC Number without Slash!")]
        public string CNIC { get; set; }
        [Required]
        [Display(Name = "Address")]
        [StringLength(100, MinimumLength = 15, ErrorMessage = "Enter Your Current Address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Enter Your Gender")]
        [Display(Name = "Gender")]
        public string gender { get; set; }
        [Required(ErrorMessage = "Enter Your Current Country")]
        [Display(Name = "Country")]
        public string country { get; set; }
    }
}
