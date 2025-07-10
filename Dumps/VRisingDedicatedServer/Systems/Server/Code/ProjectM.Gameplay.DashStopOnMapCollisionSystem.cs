using Unity.Entities;

namespace ProjectM.Gameplay;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[UpdateAfter(typeof(ProjectM.MapCollisionSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class DashStopOnMapCollisionSystem : SystemBase
{
    EntityQuery __query_691853110_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_691853110_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Buff>(),
                ComponentType.ReadWrite<ProjectM.Dash>(),
            },
        });
        
    }
    

}
