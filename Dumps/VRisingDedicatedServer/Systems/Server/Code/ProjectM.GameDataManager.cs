using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.PrefabInitializationGroup), OrderFirst = true)]
[UpdateBefore(typeof(ProjectM.PrefabCollectionSystem))]
[UpdateAfter(typeof(ProjectM.GameDataSubSceneSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class GameDataManager : SystemBase
{
    EntityQuery _LoadingStartedQuery;
    EntityQuery _GameDataSceneQuery;
    EntityQuery _LoadingSubSceneQuery;
    EntityQuery _RegisterPrefabQuery;
    EntityQuery __query_1952729121_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _LoadingStartedQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.GameDataLoadingStartedSingleton>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeAll,
        });
        
        _GameDataSceneQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.GameDataSubSceneTag>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeAll,
        });
        
        _LoadingSubSceneQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.GameDataSubSceneTag>(),
                ComponentType.ReadWrite<ProjectM.WaitingForSceneLoad>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeAll,
        });
        
        _RegisterPrefabQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<Stunlock.Core.RegisterPrefab>(),
                ComponentType.ReadWrite<Stunlock.Core.RegisterPrefabEvent>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_1952729121_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.WorldTypeSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
