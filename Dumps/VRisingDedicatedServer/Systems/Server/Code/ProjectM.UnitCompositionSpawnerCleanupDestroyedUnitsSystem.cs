using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct UnitCompositionSpawnerCleanupDestroyedUnitsSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _MainQuery;
    EntityQuery __query_707729506_0;
    EntityQuery __query_707729506_1;
    EntityQuery __query_707729506_2;
    EntityQuery __query_707729506_3;
    
    // unmanaged system, skipped generating example queries

}
