using Unity.Entities;

namespace ProjectM.Gameplay;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct RepairInvalidInventoryRouteParentsSystem_Spawn : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_2048371328_0;
    
    // unmanaged system, skipped generating example queries

}
