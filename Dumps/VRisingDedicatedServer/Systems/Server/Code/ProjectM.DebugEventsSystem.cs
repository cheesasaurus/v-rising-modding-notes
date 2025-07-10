using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.StartSimulationNetworkGroup))]
[UpdateAfter(typeof(ProjectM.ServerBootstrapSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class DebugEventsSystem : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_1620062683_0;
    EntityQuery __query_1620062683_1;
    EntityQuery __query_1620062683_2;
    EntityQuery __query_1620062683_3;
    EntityQuery __query_1620062683_4;
    EntityQuery __query_1620062683_5;
    EntityQuery __query_1620062683_6;
    EntityQuery __query_1620062683_7;
    EntityQuery __query_1620062683_8;
    EntityQuery __query_1620062683_9;
    EntityQuery __query_1620062683_10;
    EntityQuery __query_1620062683_11;
    EntityQuery __query_1620062683_12;
    EntityQuery __query_1620062683_13;
    EntityQuery __query_1620062683_14;
    EntityQuery __query_1620062683_15;
    EntityQuery __query_1620062683_16;
    EntityQuery __query_1620062683_17;
    EntityQuery __query_1620062683_18;
    EntityQuery __query_1620062683_19;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.Network.HandleClientDebugEvent>(),
            },
        });
        
        __query_1620062683_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.DayNightCycle>(),
            },
        });
        
        __query_1620062683_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.ServerTime>(),
            },
        });
        
        __query_1620062683_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AchievementData>(),
                ComponentType.ReadOnly<Stunlock.Core.PrefabGUID>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeAll,
        });
        
        __query_1620062683_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityOwner>(),
                ComponentType.ReadWrite<ProjectM.AbilityCooldownState>(),
            },
        });
        
        __query_1620062683_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityOwner>(),
                ComponentType.ReadWrite<ProjectM.AbilityChargesState>(),
                ComponentType.ReadOnly<ProjectM.AbilityChargesData>(),
            },
        });
        
        __query_1620062683_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.User>(),
                ComponentType.ReadOnly<ProjectM.TeamReference>(),
            },
        });
        
        __query_1620062683_6 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Controller>(),
                ComponentType.ReadOnly<ProjectM.Network.User>(),
            },
        });
        
        __query_1620062683_7 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.VBloodUnitSpawnSource>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<ProjectM.UnitCompositionGroupUnitEntry>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_1620062683_8 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.PlayerCharacter>(),
            },
        });
        
        __query_1620062683_9 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.PrefabLookupMap>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1620062683_10 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.NetworkIdSystem.Singleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1620062683_11 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.WorldFrame>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1620062683_12 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.SyncedServerDebugSettings>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1620062683_13 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.SyncedServerDebugSettings>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1620062683_14 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UnitTeam>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1620062683_15 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerRuntimeSettings>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1620062683_16 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Physics.PhysicsWorldSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1620062683_17 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerGameBalanceSettings>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1620062683_18 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Shared.RelicDropped>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1620062683_19 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.RootPrefabCollection>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
