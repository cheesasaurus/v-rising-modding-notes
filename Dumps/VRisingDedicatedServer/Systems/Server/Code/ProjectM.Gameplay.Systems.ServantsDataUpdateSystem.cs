using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.UpdateGroup), OrderFirst = true)]
[RequireMatchingQueriesForUpdateAttribute]
public struct ServantsDataUpdateSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_651610256_0;
    EntityQuery __query_651610256_1;
    EntityQuery __query_651610256_2;
    
    // unmanaged system, skipped generating example queries

}
