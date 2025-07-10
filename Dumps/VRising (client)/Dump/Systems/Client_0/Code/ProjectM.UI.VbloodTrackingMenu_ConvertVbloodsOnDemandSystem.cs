using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class VbloodTrackingMenu_ConvertVbloodsOnDemandSystem : SystemBase
{

}
