using Unity.Entities;

namespace ProjectM.Behaviours;


[UpdateInGroup(typeof(ProjectM.AiSubGroup2))]
[UpdateAfter(typeof(ProjectM.Behaviours.BehaviourTreeStateChangedEventSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class BehaviourTreeStateBuffsSystem_Spawn : SystemBase
{
    EntityQuery __query_536512561_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_536512561_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Behaviours.BehaviourTreeStateChangedEvent>(),
            },
        });
        
    }
    

}
