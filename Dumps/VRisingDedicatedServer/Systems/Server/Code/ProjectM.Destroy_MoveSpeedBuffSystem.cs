using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class Destroy_MoveSpeedBuffSystem : SystemBase
{
    EntityQuery __query_212240448_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_212240448_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ModifyMovementSpeedBuffModification>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
    }
    

}
