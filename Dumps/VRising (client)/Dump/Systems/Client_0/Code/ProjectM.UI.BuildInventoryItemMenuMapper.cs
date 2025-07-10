using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.BuildModeGroup), OrderFirst = true)]
[RequireMatchingQueriesForUpdateAttribute]
public class BuildInventoryItemMenuMapper : SystemBase, ProjectM.IInputContext
{
    EntityQuery __query_2062195447_0;
    EntityQuery __query_2062195447_1;
    EntityQuery __query_2062195447_2;
    EntityQuery __query_2062195447_3;
    EntityQuery __query_2062195447_4;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_2062195447_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.BuildInventoryItemMenu>(),
            },
        });
        
        __query_2062195447_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UI.BuildInventoryItemMenu.InitData>(),
            },
        });
        
        __query_2062195447_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.PrefabLookupMap>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_2062195447_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.CastleBuilding.BuildModePlacementOperation>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_2062195447_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.BuildModeState>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
