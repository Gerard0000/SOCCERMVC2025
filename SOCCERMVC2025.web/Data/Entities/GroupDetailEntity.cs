using System.ComponentModel.DataAnnotations;

namespace SOCCERMVC2025.web.Data.Entities;

public class GroupDetailEntity
{
    public int Id { get; set; }

    public TeamEntity? Team { get; set; }

    [Display(Name = "Matches Played")]
    public int MatchesPlayed { get; set; }

    [Display(Name = "Matches Won")]
    public int MatchesWon { get; set; }

    [Display(Name = "Matches Tied")]
    public int MatchesTied { get; set; }

    [Display(Name = "Matches Lost")]
    public int MatchesLost { get; set; }

    public int Points => MatchesWon * 3 + MatchesTied;

    [Display(Name = "Goals For")]
    public int GoalsFor { get; set; }

    [Display(Name = "Goals Against")]
    public int GoalsAgainst { get; set; }

    [Display(Name = "Goals Difference")]
    public int GoalDifference => GoalsFor - GoalsAgainst;

    //un detalle de grupo pertenece a un grupo
    public GroupEntity? Group { get; set; }
}