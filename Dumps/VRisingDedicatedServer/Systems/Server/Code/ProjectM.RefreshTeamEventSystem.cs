using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToTransformGroup))]
[UpdateAfter(typeof(ProjectM.ChangeAllegianceEventSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public struct RefreshTeamEventSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _RefreshEventQuery;
    EntityQuery __query_57017769_0;
    
    // unmanaged system, skipped generating example queries

}
