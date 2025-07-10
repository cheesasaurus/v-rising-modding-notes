using Unity.Entities;

namespace ProjectM.Gameplay;


[UpdateInGroup(typeof(ProjectM.ReactToPersistenceLoadedGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct RepairInvalidInventoryRouteParentsSystem_Persistence : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_2048371368_0;
    
    // unmanaged system, skipped generating example queries

}
