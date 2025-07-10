using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class DownedEventSystem : SystemBase
{
    EntityQuery _DownedEventQuery;
    EntityQuery _SpawnedDownedBuffQuery;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _DownedEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.DownedEvent>(),
            },
        });
        
        _SpawnedDownedBuffQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.DownedBuff>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
    }
    

}
