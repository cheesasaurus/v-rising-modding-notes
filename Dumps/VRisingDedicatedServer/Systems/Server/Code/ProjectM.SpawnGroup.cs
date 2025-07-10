using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.RecursiveGroup))]
[UpdateAfter(typeof(ProjectM.SpawnBarrier))]
public class SpawnGroup : ComponentSystemGroup
{
    EntityQuery _QuerySpawned;
    EntityQuery _QueryDisabled;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _QuerySpawned = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.DisabledWaitingForSync>(),
                ComponentType.ReadOnly<ProjectM.DisabledWaitingForTransform>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        _QueryDisabled = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.DisabledDueToNoPlayersInRange>(),
                ComponentType.ReadWrite<Unity.Entities.SpawnTag>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
    }
    

}
