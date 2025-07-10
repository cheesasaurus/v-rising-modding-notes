using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.UIGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class EmotesMenuMapperSystem : ProjectM.UI.PowerSelectionMenuMapperSystem<ProjectM.UI.EmotesMenu>, ProjectM.IInputContext
{

}
