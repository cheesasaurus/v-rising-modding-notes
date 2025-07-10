using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.UIGroup))]
[UpdateAfter(typeof(ProjectM.UI.DebugViewBinderSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class DebugViewMapper : SystemBase
{
    EntityQuery __query_1062804268_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1062804268_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.UICanvasBase>(),
            },
        });
        
    }
    

}
