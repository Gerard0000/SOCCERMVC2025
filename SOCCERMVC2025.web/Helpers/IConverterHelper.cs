using SOCCERMVC2025.web.Data.Entities;
using SOCCERMVC2025.web.Models;

namespace SOCCERMVC2025.web.Helpers;

public interface IConverterHelper
{
    TeamEntity ToTeamEntity(TeamViewModel model, string path, bool isNew);

    TeamViewModel ToTeamViewModel(TeamEntity teamEntity);
}