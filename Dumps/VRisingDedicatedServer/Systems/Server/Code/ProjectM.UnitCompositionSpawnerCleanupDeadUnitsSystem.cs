using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDeadGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct UnitCompositionSpawnerCleanupDeadUnitsSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_707729547_0;
    EntityQuery __query_707729547_1;
    EntityQuery __query_707729547_2;
    EntityQuery __query_707729547_3;
    
    // unmanaged system, skipped generating example queries

}
