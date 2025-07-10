using Unity.Entities;

namespace ProjectM.Contest.Arena;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct CastleArenaObserveSequenceSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_1167104442_0;
    EntityQuery __query_1167104442_1;
    EntityQuery __query_1167104442_2;
    
    // unmanaged system, skipped generating example queries

}
