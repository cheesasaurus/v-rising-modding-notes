using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class Destroy_KnockbackResistanceBuff : SystemBase
{
    EntityQuery __query_1575725533_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1575725533_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.ChangeKnockbackResistanceBuff>(),
                ComponentType.ReadWrite<ProjectM.ChangeKnockbackResistanceBuffModification>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
    }
    

}
