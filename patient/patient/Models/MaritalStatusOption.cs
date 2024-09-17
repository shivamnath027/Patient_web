using System.ComponentModel.DataAnnotations;

namespace PatientInformationSystem.Models
{
    public class MaritalStatusOption
    {
        public int ID { get; set; }

        [Required]
        public string Status { get; set; }
    }
}
