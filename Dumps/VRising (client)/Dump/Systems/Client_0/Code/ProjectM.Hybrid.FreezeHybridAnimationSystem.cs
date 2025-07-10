using Unity.Entities;

namespace ProjectM.Hybrid;


[UpdateInGroup(typeof(ProjectM.SetHybridDataGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class FreezeHybridAnimationSystem : SystemBase
{
    EntityQuery __query_1866984389_0;
    EntityQuery __query_1866984389_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1866984389_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.FreezeHybridAnimationData>(),
            },
        });
        
        __query_1866984389_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.FreezeHybridAnimationData>(),
            },
        });
        
    }
    

}
