using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.BuildModeGroup), OrderFirst = true)]
[RequireMatchingQueriesForUpdateAttribute]
public class ArenaZoneMenuMapper : SystemBase, ProjectM.IInputContext
{
    EntityQuery __query_1677654586_0;
    EntityQuery __query_1677654586_1;
    EntityQuery __query_1677654586_2;
    EntityQuery __query_1677654586_3;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1677654586_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.ArenaZoneMenu>(),
            },
        });
        
        __query_1677654586_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UI.ArenaZoneMenu.InitData>(),
            },
        });
        
        __query_1677654586_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.ArenaOperation>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1677654586_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.BuildModeState>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
