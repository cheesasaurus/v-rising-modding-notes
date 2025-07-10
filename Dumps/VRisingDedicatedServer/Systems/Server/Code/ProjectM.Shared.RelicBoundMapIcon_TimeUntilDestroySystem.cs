using Unity.Entities;

namespace ProjectM.Shared;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct RelicBoundMapIcon_TimeUntilDestroySystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_2106232068_0;
    EntityQuery __query_2106232068_1;
    
    // unmanaged system, skipped generating example queries

}
