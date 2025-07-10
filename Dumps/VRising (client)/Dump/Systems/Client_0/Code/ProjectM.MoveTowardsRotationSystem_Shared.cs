using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.InputGroup))]
[UpdateAfter(typeof(ProjectM.SetInputGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class MoveTowardsRotationSystem_Shared : SystemBase
{
    EntityQuery __query_335314811_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_335314811_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.MoveTowardsRotationBuff>(),
                ComponentType.ReadOnly<Unity.Transforms.Rotation>(),
            },
        });
        
    }
    

}
