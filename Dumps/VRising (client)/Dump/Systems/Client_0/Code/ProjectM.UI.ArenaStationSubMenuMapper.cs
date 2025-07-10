using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.UIGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ArenaStationSubMenuMapper : SystemBase, ProjectM.IInputContext
{
    EntityQuery __query_118350817_0;
    EntityQuery __query_118350817_1;
    EntityQuery __query_118350817_2;
    EntityQuery __query_118350817_3;
    EntityQuery __query_118350817_4;
    EntityQuery __query_118350817_5;
    EntityQuery __query_118350817_6;
    EntityQuery __query_118350817_7;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_118350817_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UI.ArenaStationSubMenu.Data>(),
                ComponentType.ReadWrite<ProjectM.UI.ArenaStationSubMenu>(),
            },
        });
        
        __query_118350817_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Contest.Arena.CastleArenaStation_Shared>(),
            },
        });
        
        __query_118350817_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Contest.ContestHUDSettingsManaged>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_118350817_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UI.ArenaStationSubMenu.Data>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_118350817_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UserInfoBufferSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_118350817_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CommonClientData>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_118350817_6 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleActiveArenaSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_118350817_7 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UI.ArenaStationSubMenu>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
