using Unity.Entities;

namespace Stunlock.Core.Authoring;


[UpdateInGroup(typeof(ProjectM.PrefabInitializationGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ProcessWaitingForBakingSystem : SystemBase
{
    EntityQuery _RegisterEventQuery;
    EntityQuery _WaitingForBakingQuery;
    EntityQuery __query_2034444649_0;
    EntityQuery __query_2034444649_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _RegisterEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.RegisterPrefabEvent>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeAll,
        });
        
        _WaitingForBakingQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<Stunlock.Core.Authoring.WaitingForBaking>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeSpawnTag | EntityQueryOptions.IncludeDestroyTag | EntityQueryOptions.IncludeAll,
        });
        
        __query_2034444649_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.RegisterPrefabEvent>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeAll,
        });
        
        __query_2034444649_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<Stunlock.Core.Authoring.WaitingForBaking>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeSpawnTag | EntityQueryOptions.IncludeDestroyTag | EntityQueryOptions.IncludeAll,
        });
        
    }
    

}
