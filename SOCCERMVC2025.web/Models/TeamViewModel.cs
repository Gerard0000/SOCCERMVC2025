using SOCCERMVC2025.web.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace SOCCERMVC2025.web.Models
{
    public class TeamViewModel : TeamEntity
    {
        [Display(Name = "Logo")]
        public IFormFile? LogoFile { get; set; }
    }
}