using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.UIGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class InventoryRouteStationSubMenuMapper : SystemBase
{
    EntityQuery _SubMenuQuery;
    EntityQuery __query_1265609740_0;
    EntityQuery __query_1265609740_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _SubMenuQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UI.InventoryRouteStationSubMenu.State>(),
                ComponentType.ReadOnly<ProjectM.UI.InventoryRouteStationSubMenu>(),
            },
        });
        
        __query_1265609740_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UI.InventoryRouteStationSubMenu.State>(),
                ComponentType.ReadOnly<ProjectM.UI.InventoryRouteStationSubMenu>(),
            },
        });
        
        __query_1265609740_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UI.InventoryRouteStationSubMenu.State>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
