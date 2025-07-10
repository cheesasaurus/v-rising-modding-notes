using Unity.Entities;

namespace ProjectM.Scripting;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[UpdateAfter(typeof(ProjectM.Scripting.ScriptUpdateServer))]
[RequireMatchingQueriesForUpdateAttribute]
public class GenericEventSystem : SystemBase
{
    EntityQuery _EventQuery;
    EntityQuery _ListenerQuery;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _EventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Scripting.GenericEvent>(),
            },
        });
        
        _ListenerQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Scripting.GenericEventListener>(),
            },
        });
        
    }
    

}
