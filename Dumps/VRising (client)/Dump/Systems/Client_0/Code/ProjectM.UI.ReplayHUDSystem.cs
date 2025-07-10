using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ReplayHUDSystem : SystemBase
{
    EntityQuery __query_2013064411_0;
    EntityQuery __query_2013064411_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_2013064411_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.UICanvasBase>(),
            },
        });
        
        __query_2013064411_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.TimeScale>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
