using Unity.Entities;

namespace ProjectM.Presentation;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class InventoryRoutePathDebugSystem : SystemBase
{
    EntityQuery _PathResultQuery;
    EntityQuery _PathBlockQuery;
    EntityQuery __query_1038473486_0;
    EntityQuery __query_1038473486_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _PathResultQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Presentation.InventoryRoutePathRequest>(),
                ComponentType.ReadOnly<ProjectM.Presentation.InventoryRoutePathResult>(),
            },
        });
        
        _PathBlockQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Presentation.InventoryRoutePathRequest>(),
                ComponentType.ReadOnly<ProjectM.Presentation.InventoryRoutePathBlock>(),
            },
        });
        
        __query_1038473486_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Presentation.InventoryRoutePathRequest>(),
                ComponentType.ReadOnly<ProjectM.Presentation.InventoryRoutePathResult>(),
            },
        });
        
        __query_1038473486_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Presentation.InventoryRoutePathRequest>(),
                ComponentType.ReadOnly<ProjectM.Presentation.InventoryRoutePathBlock>(),
            },
        });
        
    }
    

}
