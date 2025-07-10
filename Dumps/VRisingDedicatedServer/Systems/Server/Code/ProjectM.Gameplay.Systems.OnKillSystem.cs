using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.ReactToDeadGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class OnKillSystem : SystemBase
{
    EntityQuery __query_1438746367_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1438746367_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.DeathEvent>(),
            },
        });
        
    }
    

}
