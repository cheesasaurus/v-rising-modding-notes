using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.DestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class SpawnChainTransitionSystem_PreDestroy : ProjectM.SpawnChainTransitionSystem
{
    EntityQuery __query_823274495_0;
    EntityQuery __query_823274495_1;
    EntityQuery _EventQuery;
    EntityQuery __query_1214202408_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_823274495_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.SpawnChainData.QueuedTransitionRequests>(),
                ComponentType.ReadOnly<ProjectM.DisableWhenNoPlayersInRangeOfChunk>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_823274495_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.DisableWhenNoPlayersInRangeOfChunkSystem.Singleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        _EventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.SpawnChainTransitionEvent>(),
            },
        });
        
        __query_1214202408_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.SpawnChainTransitionEvent>(),
            },
        });
        
    }
    

}
