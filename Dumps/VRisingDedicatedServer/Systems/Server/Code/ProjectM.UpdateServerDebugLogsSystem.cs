using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class UpdateServerDebugLogsSystem : SystemBase
{
    EntityQuery __query_1499048275_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1499048275_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.ServerDebugLogs>(),
            },
        });
        
    }
    

}
