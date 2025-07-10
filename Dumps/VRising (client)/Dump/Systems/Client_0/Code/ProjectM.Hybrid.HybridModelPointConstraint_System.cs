using Unity.Entities;

namespace ProjectM.Hybrid;


[UpdateInGroup(typeof(ProjectM.SetHybridDataGroup))]
[UpdateAfter(typeof(ProjectM.Hybrid.SetHybridModelAnimationSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class HybridModelPointConstraint_System : SystemBase
{
    EntityQuery __query_1562427589_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1562427589_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Hybrid.HybridModel>(),
                ComponentType.ReadWrite<ProjectM.Hybrid.HybridModelPointConstraint>(),
            },
        });
        
    }
    

}
