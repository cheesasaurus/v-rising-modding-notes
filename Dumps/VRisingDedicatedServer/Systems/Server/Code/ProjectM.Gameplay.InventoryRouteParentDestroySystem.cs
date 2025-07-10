using Unity.Entities;

namespace ProjectM.Gameplay;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct InventoryRouteParentDestroySystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_2048370671_0;
    
    // unmanaged system, skipped generating example queries

}
