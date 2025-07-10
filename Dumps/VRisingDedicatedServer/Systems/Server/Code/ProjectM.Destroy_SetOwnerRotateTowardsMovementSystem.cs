using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class Destroy_SetOwnerRotateTowardsMovementSystem : SystemBase
{
    EntityQuery __query_1161311172_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1161311172_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.SetOwnerRotateTowardsMovementSystem.Modification>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
    }
    

}
