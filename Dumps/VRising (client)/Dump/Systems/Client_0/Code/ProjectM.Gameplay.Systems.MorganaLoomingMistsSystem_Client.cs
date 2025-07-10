using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct MorganaLoomingMistsSystem_Client : ISystem, ISystemCompilerGenerated
{
    EntityQuery _MistQuery;
    EntityQuery __query_1134205354_0;
    EntityQuery __query_1134205354_1;
    EntityQuery __query_1134205354_2;
    
    // unmanaged system, skipped generating example queries

}
