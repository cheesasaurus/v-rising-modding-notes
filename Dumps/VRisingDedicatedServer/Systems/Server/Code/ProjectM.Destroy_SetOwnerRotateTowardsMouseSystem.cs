using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class Destroy_SetOwnerRotateTowardsMouseSystem : SystemBase
{
    EntityQuery __query_1104717342_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1104717342_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.SetOwnerRotateTowardsMouseSystem.Modification>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
    }
    

}
