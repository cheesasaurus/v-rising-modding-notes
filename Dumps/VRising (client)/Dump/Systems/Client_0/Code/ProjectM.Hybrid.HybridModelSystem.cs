using Unity.Entities;

namespace ProjectM.Hybrid;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[UpdateBefore(typeof(ProjectM.GetHybridDataGroup))]
[UpdateBefore(typeof(ProjectM.AudioGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class HybridModelSystem : SystemBase
{

}
