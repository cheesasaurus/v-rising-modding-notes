using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class SetOwnerRotateTowardsMovementSystem : SystemBase
{
    EntityQuery __query_1161311123_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1161311123_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.SetOwnerRotateTowardsMovement>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.SetOwnerRotateTowardsMovementSystem.Modification>(),
            },
        });
        
    }
    

}
