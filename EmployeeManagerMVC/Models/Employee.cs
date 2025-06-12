using System.ComponentModel.DataAnnotations;

namespace EmployeeManagerMVC.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public string Imie { get; set; }

        [Required]
        public string Nazwisko { get; set; }

        [Required]
        public string Stanowisko { get; set; }

        [Range(0, 50)]
        public int LataDoswiadczenia { get; set; }
    }
}
