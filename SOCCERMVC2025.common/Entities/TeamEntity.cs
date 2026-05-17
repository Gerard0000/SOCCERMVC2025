using System.ComponentModel.DataAnnotations;

namespace SOCCERMVC2025.web.Data.Entities;

public class TeamEntity
{
    public int Id { get; set; }

    [MaxLength(50, ErrorMessage = "The {0} field cant not have more than {1} characters.")]
    [Required(ErrorMessage = "The field {0} is mandatory.")]
    public string Name { get; set; } = null!;

    public string LogoPath { get; set; } = null!;
}