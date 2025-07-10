using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.UIGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class SpellbookMenuMapperSystem : ProjectM.UI.FullscreenMenuViewMapperSystem<ProjectM.UI.SpellbookMenu>, ProjectM.IInputContext
{

}
