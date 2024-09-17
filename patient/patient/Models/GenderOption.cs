using System.ComponentModel.DataAnnotations;

namespace PatientInformationSystem.Models
{
    public class GenderOption
    {
        public int ID { get; set; }

        [Required]
        public string Gender { get; set; }
    }
}
