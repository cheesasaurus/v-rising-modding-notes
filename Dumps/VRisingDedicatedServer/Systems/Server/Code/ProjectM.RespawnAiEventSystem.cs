using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[UpdateAfter(typeof(ProjectM.ScheduleParentGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class RespawnAiEventSystem : SystemBase
{
    EntityQuery _EventQuery;
    EntityQuery __query_1524197426_0;
    EntityQuery __query_1524197426_1;
    EntityQuery __query_1524197426_2;
    EntityQuery __query_1524197426_3;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _EventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.RespawnAiEvent>(),
            },
        });
        
        __query_1524197426_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.RespawnAiEvent>(),
            },
        });
        
        __query_1524197426_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.SpawnRegionSpawnSlotEntry>(),
            },
        });
        
        __query_1524197426_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.SpawnRegion>(),
            },
        });
        
        __query_1524197426_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CollisionDetectionSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
