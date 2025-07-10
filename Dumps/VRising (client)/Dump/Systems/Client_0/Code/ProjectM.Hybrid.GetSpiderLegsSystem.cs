using Unity.Entities;

namespace ProjectM.Hybrid;


[UpdateInGroup(typeof(ProjectM.GetHybridDataGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class GetSpiderLegsSystem : SystemBase
{
    EntityQuery __query_2132794181_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_2132794181_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Hybrid.SpiderLegsDriver>(),
                ComponentType.ReadWrite<ProjectM.Hybrid.SpiderLeg>(),
                ComponentType.ReadWrite<ProjectM.Hybrid.HybridIKSpiderLegs>(),
            },
        });
        
    }
    

}
