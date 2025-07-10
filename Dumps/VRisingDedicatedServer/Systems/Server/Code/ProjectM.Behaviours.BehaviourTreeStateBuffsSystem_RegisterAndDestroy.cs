using Unity.Entities;

namespace ProjectM.Behaviours;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class BehaviourTreeStateBuffsSystem_RegisterAndDestroy : SystemBase
{
    EntityQuery _RegisterQuery;
    EntityQuery __query_536512641_0;
    EntityQuery __query_536512641_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _RegisterQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Behaviours.RegisterBehaviourTreeStateBuff>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
        __query_536512641_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Behaviours.RegisterBehaviourTreeStateBuff>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
        __query_536512641_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Behaviours.BehaviourTreeStateChangedEvent>(),
            },
        });
        
    }
    

}
