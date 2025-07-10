using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class SetOwnerRotateTowardsMouseSystem : SystemBase
{
    EntityQuery __query_1104717293_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1104717293_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.SetOwnerRotateTowardsMouse>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.SetOwnerRotateTowardsMouseSystem.Modification>(),
            },
        });
        
    }
    

}
