using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.UIGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class TraderSubMenuMapper : SystemBase, ProjectM.IInputContext
{
    EntityQuery _Query;
    EntityQuery _ResponseQuery;
    EntityQuery __query_965451172_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.TraderSubMenuMapper.TraderMenuTarget>(),
                ComponentType.ReadWrite<ProjectM.UI.TraderSubMenu>(),
            },
        });
        
        _ResponseQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Network.ClientActionResponseEvent>(),
            },
        });
        
        __query_965451172_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UI.TraderSubMenuMapper.TraderMenuTarget>(),
                ComponentType.ReadOnly<ProjectM.UI.TraderSubMenu>(),
            },
        });
        
    }
    

}
