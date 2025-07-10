using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ChangeKnockbackResistanceDuringCast_OnDestroy : SystemBase
{
    EntityQuery __query_1589524919_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1589524919_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityOwner>(),
                ComponentType.ReadOnly<ProjectM.ChangeKnockbackResistanceDuringCast>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
    }
    

}
