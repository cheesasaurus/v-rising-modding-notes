using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ConsoleCommandGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ServerConsoleCommandSystem : ProjectM.GameplayConsoleCommandSystem
{
    EntityQuery __query_2011224692_0;
    EntityQuery __query_2011224692_1;
    EntityQuery __query_2011224692_2;
    EntityQuery __query_2011224692_3;
    EntityQuery __query_2011224692_4;
    EntityQuery __query_2011224692_5;
    EntityQuery __query_2011224692_6;
    EntityQuery __query_2011224692_7;
    EntityQuery __query_2011224692_8;
    EntityQuery __query_2011224692_9;
    EntityQuery __query_2011224692_10;
    EntityQuery __query_2011224692_11;
    EntityQuery __query_2011224692_12;
    EntityQuery __query_2011224692_13;
    EntityQuery __query_2011224692_14;
    EntityQuery __query_2011224692_15;
    EntityQuery __query_2011224692_16;
    EntityQuery __query_2011224692_17;
    EntityQuery __query_2011224692_18;
    EntityQuery __query_2011224692_19;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_2011224692_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UnitStats>(),
            },
        });
        
        __query_2011224692_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.VBloodUnit>(),
                ComponentType.ReadOnly<Stunlock.Core.PrefabGUID>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_2011224692_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.User>(),
            },
        });
        
        __query_2011224692_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.MapIconTargetEntity>(),
                ComponentType.ReadWrite<ProjectM.PlayerMapIcon>(),
            },
        });
        
        __query_2011224692_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AbilityGroupState>(),
                ComponentType.ReadOnly<ProjectM.Shared.AbilitySpellModItem>(),
                ComponentType.ReadOnly<Unity.Entities.Prefab>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeAll,
        });
        
        __query_2011224692_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.User>(),
                ComponentType.ReadOnly<ProjectM.Network.IsConnected>(),
            },
        });
        
        __query_2011224692_6 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UnitCompositionSpawner>(),
                ComponentType.ReadOnly<ProjectM.UnitCompositionSpawnerDebugName>(),
                ComponentType.ReadOnly<ProjectM.UnitCompositionActiveUnit>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_2011224692_7 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Wallpaper_Synced_0>(),
                ComponentType.ReadOnly<ProjectM.WallpaperStyles>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_2011224692_8 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Wallpaper_Synced_90>(),
                ComponentType.ReadOnly<ProjectM.WallpaperStyles>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_2011224692_9 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Wallpaper_Synced_180>(),
                ComponentType.ReadOnly<ProjectM.WallpaperStyles>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_2011224692_10 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Wallpaper_Synced_270>(),
                ComponentType.ReadOnly<ProjectM.WallpaperStyles>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_2011224692_11 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.ConnectedUser>(),
            },
        });
        
        __query_2011224692_12 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.ServerRuntimeSettings>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_2011224692_13 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerTime>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_2011224692_14 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerRuntimeSettings>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_2011224692_15 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Physics.DebugShowPhysicsCasts>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_2011224692_16 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.PersistenceDebuggingSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_2011224692_17 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.RootPrefabCollection>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_2011224692_18 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerRootPrefabCollection>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_2011224692_19 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.DayNightCycle>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
