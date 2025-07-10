using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class RelicDestroySystem : SystemBase
{
    EntityQuery _InventoriesQuery;
    EntityQuery _RelicsQuery;
    EntityQuery _DestroyedInventoriesQuery;
    EntityQuery __query_1425231924_0;
    EntityQuery __query_1425231924_1;
    EntityQuery __query_1425231924_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _InventoriesQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.InventoryBuffer>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeDestroyTag | EntityQueryOptions.IncludeAll,
        });
        
        _RelicsQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ItemData>(),
                ComponentType.ReadOnly<ProjectM.Shared.Relic>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
            Options = EntityQueryOptions.IncludeDestroyTag | EntityQueryOptions.IncludeAll,
        });
        
        _DestroyedInventoriesQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.InventoryBuffer>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
            Options = EntityQueryOptions.IncludeDestroyTag | EntityQueryOptions.IncludeAll,
        });
        
        __query_1425231924_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.InventoryBuffer>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
            Options = EntityQueryOptions.IncludeDestroyTag | EntityQueryOptions.IncludeAll,
        });
        
        __query_1425231924_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ItemData>(),
                ComponentType.ReadOnly<ProjectM.Shared.Relic>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
            Options = EntityQueryOptions.IncludeDestroyTag | EntityQueryOptions.IncludeAll,
        });
        
        __query_1425231924_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Shared.RelicDropped>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
