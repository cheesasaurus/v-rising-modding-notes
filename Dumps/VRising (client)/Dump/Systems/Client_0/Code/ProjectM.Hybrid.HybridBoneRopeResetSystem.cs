using Unity.Entities;

namespace ProjectM.Hybrid;


[UpdateInGroup(typeof(SimulationSystemGroup))]
[UpdateBefore(typeof(ProjectM.BeforeTransformSystemGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class HybridBoneRopeResetSystem : SystemBase
{
    EntityQuery __query_544736096_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_544736096_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Hybrid.StunclothBoneRopeComponent>(),
            },
        });
        
    }
    

}
