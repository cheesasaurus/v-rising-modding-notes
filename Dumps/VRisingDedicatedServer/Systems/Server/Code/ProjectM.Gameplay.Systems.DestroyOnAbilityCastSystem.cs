using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.AbilityGroup), OrderLast = true)]
[RequireMatchingQueriesForUpdateAttribute]
public struct DestroyOnAbilityCastSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _MainQuery;
    EntityQuery __query_584626447_0;
    
    // unmanaged system, skipped generating example queries

}
