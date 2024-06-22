using System.ComponentModel.DataAnnotations;

namespace BtkAkademi.Models
{
    public class Candidate
    {
        [Required]
        public String? Email { get; set; } =  String.Empty;
        [Required]
        public String? FirstName { get; set; } =  String.Empty;
        [Required]
        public String? LastName { get; set; } =  String.Empty;
        [Required]
        public String? FullName  => $"{FirstName }  {LastName?.ToUpper()}";
        [Required]
        public int? Age { get; set; }
        [Required]
        public String? SelectedCourse { get; set; }   =  String.Empty;
        [Required]
        public DateTime? ApplyAt { get; set; }

        public Candidate()
        {
            ApplyAt =  DateTime.Now;
        }
    }
}