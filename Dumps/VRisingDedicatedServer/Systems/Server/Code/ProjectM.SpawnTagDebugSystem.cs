using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.SpawnGroup), OrderFirst = true)]
[RequireMatchingQueriesForUpdateAttribute]
public class SpawnTagDebugSystem : SystemBase
{
    EntityQuery _QueryWaitingForSync;
    EntityQuery _QueryWaitingForTransform;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _QueryWaitingForSync = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.DisabledWaitingForSync>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Entities.Disabled>(),
            },
        });
        
        _QueryWaitingForTransform = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.DisabledWaitingForTransform>(),
                ComponentType.ReadWrite<Unity.Entities.SpawnTag>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Entities.Disabled>(),
            },
        });
        
    }
    

}
