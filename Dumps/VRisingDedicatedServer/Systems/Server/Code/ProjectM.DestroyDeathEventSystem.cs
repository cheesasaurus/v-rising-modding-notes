using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDeadGroup), OrderLast = true)]
[RequireMatchingQueriesForUpdateAttribute]
public class DestroyDeathEventSystem : SystemBase
{
    EntityQuery _DeathEventQuery;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _DeathEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.DeathEvent>(),
            },
        });
        
    }
    

}
