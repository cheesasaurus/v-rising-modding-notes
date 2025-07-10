using Unity.Entities;

namespace ProjectM.Contest;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ContestRenderSystem : SystemBase
{
    EntityQuery _ContestQuery;
    EntityQuery __query_647478391_0;
    EntityQuery __query_647478391_1;
    EntityQuery __query_647478391_2;
    EntityQuery __query_647478391_3;
    EntityQuery __query_647478391_4;
    EntityQuery __query_647478391_5;
    EntityQuery __query_647478391_6;
    EntityQuery __query_647478391_7;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _ContestQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Contest.ContestOwner_Shared>(),
            },
            Any = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.DuelArea>(),
                ComponentType.ReadOnly<ProjectM.CastleArenaBlock>(),
            },
        });
        
        __query_647478391_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Contest.ContestOwner_Shared>(),
            },
            Any = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.DuelArea>(),
                ComponentType.ReadOnly<ProjectM.CastleArenaBlock>(),
            },
        });
        
        __query_647478391_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CommonClientData>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_647478391_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Contest.ContestRenderSettingsManaged>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_647478391_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CurveCollection>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_647478391_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Contest.ContestRenderSettings>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_647478391_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerTime>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_647478391_6 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleActiveArenaSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_647478391_7 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Contest.ContestFullscreenEffectSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
