using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[UpdateAfter(typeof(ProjectM.UI.ScrollingCombatTextParentBinderSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class ScrollingCombatTextParentMapper : SystemBase
{
    EntityQuery __query_451949616_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_451949616_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.UICanvasBase>(),
            },
        });
        
    }
    

}
