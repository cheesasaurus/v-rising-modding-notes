using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.SetInputGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class MoveTowardsPositionSystem_Shared_Update : SystemBase
{
    EntityQuery __query_356229735_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_356229735_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.MoveTowardsPositionBuff>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
            },
        });
        
    }
    

}
