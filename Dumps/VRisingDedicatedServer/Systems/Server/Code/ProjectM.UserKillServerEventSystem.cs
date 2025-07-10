using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDeadGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class UserKillServerEventSystem : SystemBase
{
    EntityQuery __query_2131123784_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_2131123784_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.DeathEvent>(),
            },
        });
        
    }
    

}
