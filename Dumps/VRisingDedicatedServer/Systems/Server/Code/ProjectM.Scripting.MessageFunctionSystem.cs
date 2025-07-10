using Unity.Entities;

namespace ProjectM.Scripting;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[UpdateAfter(typeof(ProjectM.Scripting.ScriptUpdateServer))]
[RequireMatchingQueriesForUpdateAttribute]
public class MessageFunctionSystem : SystemBase
{
    EntityQuery _EventQuery;
    EntityQuery __query_1066692717_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _EventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Scripting.MessageFunctionEvent>(),
            },
        });
        
        __query_1066692717_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Scripting.MessageFunctionEvent>(),
            },
        });
        
    }
    

}
