using Unity.Entities;

namespace ProjectM.Network;


[UpdateInGroup(typeof(ProjectM.SerializeGroup), OrderFirst = true)]
[RequireMatchingQueriesForUpdateAttribute]
public class SetupNetworkIdSystem_PreSerialize : SystemBase
{
    EntityQuery _SetupNetworkIdQuery;
    EntityQuery __query_1510972539_0;
    EntityQuery __query_1510972539_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _SetupNetworkIdQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Network.NetworkId>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_1510972539_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.SetupNetworkIdSystem.Singleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1510972539_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.NetworkIdSystem.Singleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
