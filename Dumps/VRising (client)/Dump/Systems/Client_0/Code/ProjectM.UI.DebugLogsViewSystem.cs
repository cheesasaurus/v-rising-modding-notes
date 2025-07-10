using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class DebugLogsViewSystem : SystemBase
{
    EntityQuery __query_24075005_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_24075005_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerDebugLogs>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
