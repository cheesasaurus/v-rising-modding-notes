using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class TravelToTargetSystem : SystemBase
{
    EntityQuery __query_857834307_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_857834307_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.TravelToTarget>(),
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadOnly<ProjectM.Age>(),
                ComponentType.ReadWrite<ProjectM.LifeTime>(),
            },
        });
        
    }
    

}
