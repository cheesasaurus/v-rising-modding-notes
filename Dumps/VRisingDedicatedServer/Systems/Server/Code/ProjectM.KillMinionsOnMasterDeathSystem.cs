using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToDeadGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class KillMinionsOnMasterDeathSystem : SystemBase
{
    EntityQuery __query_166460252_0;
    EntityQuery __query_166460252_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_166460252_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.DeathEvent>(),
            },
        });
        
        __query_166460252_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.DownedEvent>(),
            },
        });
        
    }
    

}
