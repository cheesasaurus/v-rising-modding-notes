using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UIGroup), OrderLast = true)]
[RequireMatchingQueriesForUpdateAttribute]
public class HandleClientActionResponseSystem : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_2002394407_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Network.ClientActionResponseEvent>(),
            },
        });
        
        __query_2002394407_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.UICanvasBase>(),
            },
        });
        
    }
    

}
