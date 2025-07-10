using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.UIGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class InventoryRouteMenuMapper : SystemBase, ProjectM.IInputContext
{
    EntityQuery __query_1432821920_0;
    EntityQuery __query_1432821920_1;
    EntityQuery __query_1432821920_2;
    EntityQuery __query_1432821920_3;
    EntityQuery __query_1432821920_4;
    EntityQuery __query_1432821920_5;
    EntityQuery __query_1432821920_6;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1432821920_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.InventoryRouteMenu>(),
            },
        });
        
        __query_1432821920_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.InventoryRouteParent>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<ProjectM.InventoryInstanceElement>(),
            },
        });
        
        __query_1432821920_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UI.InventoryRouteMenu.InitData>(),
            },
        });
        
        __query_1432821920_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CommonClientData>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1432821920_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.InventoryRouteOperation>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1432821920_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.PlannedInventoryRoute>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1432821920_6 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.BuildModeState>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
