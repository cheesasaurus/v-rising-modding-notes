using Unity.Entities;

namespace ProjectM.Contest;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ContestFullscreenEffectSystem : SystemBase
{
    EntityQuery __query_647478957_0;
    EntityQuery __query_647478957_1;
    EntityQuery __query_647478957_2;
    EntityQuery __query_647478957_3;
    EntityQuery __query_647478957_4;
    EntityQuery __query_647478957_5;
    EntityQuery __query_647478957_6;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_647478957_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Contest.ContestOwner_Shared>(),
            },
        });
        
        __query_647478957_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Contest.ContestFullscreenEffectSingleton>(),
            },
        });
        
        __query_647478957_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Contest.ContestRenderSettingsManaged>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_647478957_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Contest.ContestFullscreenEffectSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_647478957_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Contest.ContestFullscreenEffectSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_647478957_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleActiveArenaSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_647478957_6 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CommonClientData>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
