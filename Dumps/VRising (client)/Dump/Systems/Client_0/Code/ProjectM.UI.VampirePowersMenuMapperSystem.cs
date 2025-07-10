using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.UIGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class VampirePowersMenuMapperSystem : ProjectM.UI.PowerSelectionMenuMapperSystem<ProjectM.UI.VampirePowersMenu>, ProjectM.IInputContext
{

}
