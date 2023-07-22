using System.ComponentModel.DataAnnotations;

namespace RegUserinCredproMVC.Models
{
    public class UpdateUserViewModel
    {
        public int Id { get; set; }

        public string Fname { get; set; } = null!;

        public string? Mname { get; set; }

        public string Lname { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string PhoneNumber { get; set; } = null!;

        public string HashPassword { get; set; } = null!;

        public string ConfirmPassword { get; set; } = null!;

        public DateTime Dob { get; set; }

        public string Gender { get; set; } = null!;

        public string UserAddress { get; set; } = null!;

        public string Pin { get; set; } = null!;

        public byte[] ProfilePhoto { get; set; } = null!;

        public byte[] DigitalSignature { get; set; } = null!;
    }
}
