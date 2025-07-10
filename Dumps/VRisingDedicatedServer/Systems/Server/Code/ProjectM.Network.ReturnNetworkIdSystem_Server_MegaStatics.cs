using Unity.Entities;

namespace ProjectM.Network;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ReturnNetworkIdSystem_Server_MegaStatics : SystemBase
{
    EntityQuery _DestroyedQuery;
    EntityQuery __query_309821574_0;
    EntityQuery __query_309821574_1;
    EntityQuery __query_309821574_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _DestroyedQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Network.NetworkId>(),
                ComponentType.ReadOnly<ProjectM.MegaStaticTag>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
        __query_309821574_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Network.NetworkId>(),
                ComponentType.ReadOnly<ProjectM.MegaStaticTag>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
        __query_309821574_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.SetupNetworkIdSystem.Singleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_309821574_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.NetworkIdSystem.Singleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
