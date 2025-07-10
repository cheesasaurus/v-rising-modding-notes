using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(InitializationSystemGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class OpenHUDMenuSystem : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_420497968_0;
    EntityQuery __query_420497968_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UI.OpenMenuEvent>(),
            },
        });
        
        __query_420497968_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.UICanvasBase>(),
            },
        });
        
        __query_420497968_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UI.OpenMenuEvent>(),
            },
        });
        
    }
    

}
