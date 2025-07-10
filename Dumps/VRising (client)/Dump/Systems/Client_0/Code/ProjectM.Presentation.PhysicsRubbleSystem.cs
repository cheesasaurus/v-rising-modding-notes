using Unity.Entities;

namespace ProjectM.Presentation;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class PhysicsRubbleSystem : SystemBase
{
    EntityQuery __query_1536361165_0;
    EntityQuery __query_1536361165_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1536361165_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Physics.PhysicsRubble>(),
            },
        });
        
        __query_1536361165_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Physics.PhysicsRubble>(),
            },
        });
        
    }
    

}
