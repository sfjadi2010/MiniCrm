using System.ComponentModel.DataAnnotations;

namespace MiniCrm.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Please enter a first name.")]
        [StringLength(50)]
        public string FirstName { get; set; } = string.Empty;
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please enter a last name.")]
        [StringLength(50)]
        public string LastName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please enter an email address.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; } = string.Empty;

        public CustomerSatus Status { get; set; }
        public CustomerType Type { get; set; }

        public Address? Address { get; set; } 
    }

    public enum CustomerType
    {
        None,
        Regular,
        Premium,
        VIP
    }

    public enum CustomerSatus
    {
        Active,
        Inactive,
    }
}
