using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.SetInputGroup))]
[UpdateBefore(typeof(ProjectM.MoveTowardsPositionSystem_Shared_Update))]
[RequireMatchingQueriesForUpdateAttribute]
public class MoveTowardsPositionSystem_Server_Update : SystemBase
{
    EntityQuery __query_356229686_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_356229686_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadWrite<ProjectM.MoveTowardsPositionBuff>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadWrite<ProjectM.MoveTowardsPositionBuff_PathElement>(),
            },
        });
        
    }
    

}
