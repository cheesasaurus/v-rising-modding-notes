using Unity.Entities;

namespace ProjectM.Shared.Systems;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
public class ServantMissionActionSystem : SystemBase
{
    EntityQuery _StartMissionEventQuery;
    EntityQuery _AbortMissionEventQuery;
    EntityQuery __query_262912332_0;
    EntityQuery __query_262912332_1;
    EntityQuery __query_262912332_2;
    EntityQuery __query_262912332_3;
    EntityQuery __query_262912332_4;
    EntityQuery __query_262912332_5;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _StartMissionEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.SendOnMissionEvent>(),
            },
        });
        
        _AbortMissionEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.AbortMissionEvent>(),
            },
        });
        
        __query_262912332_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServantCoffinstation>(),
            },
        });
        
        __query_262912332_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.SendOnMissionEvent>(),
            },
        });
        
        __query_262912332_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.AbortMissionEvent>(),
            },
        });
        
        __query_262912332_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.PrefabLookupMap>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_262912332_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServantMissionSettingsSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_262912332_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.NetworkIdSystem.Singleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
