using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.UIGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class VBloodTrackingMenuMapperSystem : ProjectM.UI.FullscreenMenuViewMapperSystem<ProjectM.UI.VBloodTrackingMenu>, ProjectM.IInputContext
{

}
