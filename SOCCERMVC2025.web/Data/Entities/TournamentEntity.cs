using System.ComponentModel.DataAnnotations;

namespace SOCCERMVC2025.web.Data.Entities;

public class TournamentEntity
{
    public int Id { get; set; }

    [MaxLength(100, ErrorMessage = "The {0} field cant not have more than {1} characters.")]
    [Required(ErrorMessage = "The field {0} is mandatory.")]
    public string? Name { get; set; }

    [DataType(DataType.DateTime)]
    [Display(Name = "Start Date")]
    [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = false)]
    public DateTime StartDate { get; set; }

    [DataType(DataType.DateTime)]
    [Display(Name = "Start Date")]
    [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = false)]
    public DateTime StartDateLocal => StartDate.ToLocalTime();

    [DataType(DataType.DateTime)]
    [Display(Name = "End Date")]
    [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = false)]
    public DateTime EndDate { get; set; }

    [DataType(DataType.DateTime)]
    [Display(Name = "End Date")]
    [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = false)]
    public DateTime EndDateLocal => EndDate.ToLocalTime();

    [Display(Name = "Is Active?")]
    public bool IsActive { get; set; }

    [Display(Name = "Logo")]
    public string? LogoPath { get; set; }

    //relación un torneo tiene muchos grupos
    public ICollection<GroupEntity>? Groups { get; set; }
}