using System.ComponentModel.DataAnnotations;

namespace SOCCERMVC2025.web.Data.Entities;

public class GroupEntity
{
    public int Id { get; set; }

    [MaxLength(30, ErrorMessage = "The {0} field cant not have more than {1} characters.")]
    [Required(ErrorMessage = "The field {0} is mandatory.")]
    public string? Name { get; set; }

    //un grupo pertenece a un torneo
    public TournamentEntity? Tournament { get; set; }

    //un grupo tiene muchos detalles de grupo
    public ICollection<GroupDetailEntity>? GroupDetails { get; set; }

    //un grupo tiene muchos detalles de grupo
    public ICollection<MatchEntity>? Matches { get; set; }
}