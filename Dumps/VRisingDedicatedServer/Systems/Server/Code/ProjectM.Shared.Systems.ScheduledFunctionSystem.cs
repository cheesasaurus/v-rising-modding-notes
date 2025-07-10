using Unity.Entities;

namespace ProjectM.Shared.Systems;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[UpdateAfter(typeof(ProjectM.Scripting.ScriptUpdateServer))]
[RequireMatchingQueriesForUpdateAttribute]
public class ScheduledFunctionSystem : SystemBase
{
    EntityQuery __query_1231292203_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1231292203_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Scripting.ScheduledFunction>(),
            },
        });
        
    }
    

}
