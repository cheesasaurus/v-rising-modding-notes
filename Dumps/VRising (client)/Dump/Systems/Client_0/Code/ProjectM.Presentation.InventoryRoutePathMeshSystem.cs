using Unity.Entities;

namespace ProjectM.Presentation;


[UpdateInGroup(typeof(ProjectM.BeforeTransformSystemGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class InventoryRoutePathMeshSystem : SystemBase
{
    EntityQuery _PathMeshCollectionQuery;
    EntityQuery __query_634374226_0;
    EntityQuery __query_634374226_1;
    EntityQuery __query_634374226_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _PathMeshCollectionQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Presentation.InventoryRoutePathMeshCollection>(),
            },
        });
        
        __query_634374226_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Presentation.InventoryRoutePathMeshCollection>(),
            },
        });
        
        __query_634374226_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.InventoryRouteSingleton_Client>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_634374226_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Presentation.InventoryRoutePathMeshCollection>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
