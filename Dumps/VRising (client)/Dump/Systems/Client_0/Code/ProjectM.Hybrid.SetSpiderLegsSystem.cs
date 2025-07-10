using Unity.Entities;

namespace ProjectM.Hybrid;


[UpdateInGroup(typeof(ProjectM.SetHybridDataGroup), OrderLast = true)]
[RequireMatchingQueriesForUpdateAttribute]
public class SetSpiderLegsSystem : SystemBase
{
    EntityQuery __query_2132794423_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_2132794423_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Hybrid.HybridModel>(),
                ComponentType.ReadWrite<ProjectM.Hybrid.SpiderLegsDriver>(),
                ComponentType.ReadOnly<ProjectM.Hybrid.SpiderLeg>(),
                ComponentType.ReadWrite<ProjectM.Hybrid.HybridIKSpiderLegs>(),
            },
        });
        
    }
    

}
