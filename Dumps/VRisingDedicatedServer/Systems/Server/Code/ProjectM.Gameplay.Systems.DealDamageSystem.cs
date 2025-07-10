using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.StatChangeGroup), OrderFirst = true)]
[RequireMatchingQueriesForUpdateAttribute]
public struct DealDamageSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_1403978454_0;
    EntityQuery __query_1403978454_1;
    
    // unmanaged system, skipped generating example queries

}
