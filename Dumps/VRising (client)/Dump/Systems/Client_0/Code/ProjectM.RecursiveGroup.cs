using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(SimulationSystemGroup))]
[UpdateAfter(typeof(ProjectM.PostUpdateBarrier))]
public class RecursiveGroup : ComponentSystemGroup
{
    EntityQuery _QuerySpawned;
    EntityQuery _QueryDestroyed;
    
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
        
        _QueryDestroyed = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.DestroyTagEvent>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
    }
    

}
