using Unity.Entities;

namespace ProjectM.Gameplay;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class InventoryRouteTransferEventSystem : SystemBase
{
    EntityQuery _EventQuery;
    EntityQuery __query_2048371033_0;
    EntityQuery __query_2048371033_1;
    EntityQuery __query_2048371033_2;
    EntityQuery __query_2048371033_3;
    EntityQuery __query_2048371033_4;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _EventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.InventoryRouteTransferEvent>(),
            },
        });
        
        __query_2048371033_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.InventoryRouteTransferEvent>(),
            },
        });
        
        __query_2048371033_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.NetworkIdSystem.Singleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_2048371033_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.GameDatas>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_2048371033_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.UserActivityGrid>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_2048371033_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.PrefabLookupMap>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
