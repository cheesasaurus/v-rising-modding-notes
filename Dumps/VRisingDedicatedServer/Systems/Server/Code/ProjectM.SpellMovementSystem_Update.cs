using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[UpdateBefore(typeof(ProjectM.MoveGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class SpellMovementSystem_Update : SystemBase
{
    EntityQuery __query_1901699906_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1901699906_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Age>(),
                ComponentType.ReadOnly<ProjectM.LifeTime>(),
                ComponentType.ReadWrite<ProjectM.SpellMovement>(),
                ComponentType.ReadWrite<Unity.Transforms.Rotation>(),
                ComponentType.ReadWrite<Unity.Transforms.Translation>(),
            },
        });
        
    }
    

}
