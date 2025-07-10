using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class UpdateModifyTeamBuffSystem : SystemBase
{
    EntityQuery __query_274758772_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_274758772_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityOwner>(),
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadWrite<ProjectM.ModifyTeamBuff>(),
            },
        });
        
    }
    

}
