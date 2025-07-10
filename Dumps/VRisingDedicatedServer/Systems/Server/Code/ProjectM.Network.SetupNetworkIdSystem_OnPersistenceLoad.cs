using Unity.Entities;

namespace ProjectM.Network;


[UpdateInGroup(typeof(ProjectM.ReactToPersistenceLoadedGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class SetupNetworkIdSystem_OnPersistenceLoad : SystemBase
{
    EntityQuery _MainQuery;
    EntityQuery __query_1510972588_0;
    EntityQuery __query_1510972588_1;
    EntityQuery __query_1510972588_2;
    EntityQuery __query_1510972588_3;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _MainQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.NetworkId>(),
            },
            Any = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.PersistenceV2.LoadedTag>(),
                ComponentType.ReadOnly<ProjectM.PersistenceV2.InstantiatedOnLoadTag>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeSpawnTag | EntityQueryOptions.IncludeDestroyTag | EntityQueryOptions.IncludeAll,
        });
        
        __query_1510972588_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.NetworkId>(),
            },
            Any = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.PersistenceV2.LoadedTag>(),
                ComponentType.ReadOnly<ProjectM.PersistenceV2.InstantiatedOnLoadTag>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeDestroyTag | EntityQueryOptions.IncludeAll,
        });
        
        __query_1510972588_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.NetworkId>(),
            },
            Any = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.PersistenceV2.LoadedTag>(),
                ComponentType.ReadOnly<ProjectM.PersistenceV2.InstantiatedOnLoadTag>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeSpawnTag | EntityQueryOptions.IncludeDestroyTag | EntityQueryOptions.IncludeAll,
        });
        
        __query_1510972588_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.SetupNetworkIdSystem.Singleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1510972588_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.NetworkIdSystem.Singleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
