using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.UIGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class FullscreenMenuMapper : SystemBase, ProjectM.IInputContext
{
    EntityQuery _Query;
    EntityQuery __query_1076994092_0;
    EntityQuery __query_1076994092_1;
    EntityQuery __query_1076994092_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.FullscreenMenu>(),
            },
        });
        
        __query_1076994092_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.FullscreenMenu>(),
            },
        });
        
        __query_1076994092_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.FullscreenMenu.InitData>(),
            },
        });
        
        __query_1076994092_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.FullscreenMenu>(),
            },
        });
        
    }
    

}
