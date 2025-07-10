using Unity.Entities;

namespace ProjectM.Contest.Arena;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct CastleArenaObserveSequenceDestroySystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_1167104524_0;
    EntityQuery __query_1167104524_1;
    
    // unmanaged system, skipped generating example queries

}
