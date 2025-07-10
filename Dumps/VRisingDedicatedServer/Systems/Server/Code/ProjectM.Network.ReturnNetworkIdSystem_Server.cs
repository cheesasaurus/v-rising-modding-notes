using Unity.Entities;

namespace ProjectM.Network;


[UpdateInGroup(typeof(ProjectM.DestroyGroup_Server))]
[UpdateBefore(typeof(ProjectM.DestroySystem_Server))]
[RequireMatchingQueriesForUpdateAttribute]
public class ReturnNetworkIdSystem_Server : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_309821537_0;
    EntityQuery __query_309821537_1;
    EntityQuery __query_309821537_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.DestroyedEntity>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.NetworkId>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_309821537_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.DestroyedEntity>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.NetworkId>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_309821537_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.SetupNetworkIdSystem.Singleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_309821537_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.DestroyedNetworkIdSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
