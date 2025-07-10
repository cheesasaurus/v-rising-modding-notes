using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[UpdateBefore(typeof(ProjectM.MoveGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class Apply_KnockbackResistanceBuff : SystemBase
{
    EntityQuery __query_1575725494_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1575725494_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.ChangeKnockbackResistanceBuff>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ChangeKnockbackResistanceBuffModification>(),
            },
        });
        
    }
    

}
