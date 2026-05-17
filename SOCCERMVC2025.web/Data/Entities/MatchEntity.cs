using System.ComponentModel.DataAnnotations;

namespace SOCCERMVC2025.web.Data.Entities;

public class MatchEntity
{
    public int Id { get; set; }

    [DataType(DataType.DateTime)]
    [Display(Name = "Start Date")]
    [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm}", ApplyFormatInEditMode = false)]
    public DateTime Date { get; set; }

    [DataType(DataType.DateTime)]
    [Display(Name = "Date")]
    [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm}", ApplyFormatInEditMode = false)]
    public DateTime DateLocal => Date.ToLocalTime();

    public TeamEntity? Local { get; set; }
    public TeamEntity? Visitor { get; set; }

    [Display(Name = "Is Closed?")]
    public bool IsClosed { get; set; }

    //un grupo tiene muchos partidos
    public GroupEntity? Group { get; set; }
}