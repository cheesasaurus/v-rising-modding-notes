using Unity.Entities;

namespace ProjectM.CastleBuilding.Systems;


[UpdateInGroup(typeof(ProjectM.BuildModeGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class BuildModeSystem : SystemBase
{
    EntityQuery __query_1698070712_0;
    EntityQuery __query_1698070712_1;
    EntityQuery __query_1698070712_2;
    EntityQuery __query_1698070712_3;
    EntityQuery __query_1698070712_4;
    EntityQuery __query_1698070712_5;
    EntityQuery __query_1698070712_6;
    EntityQuery __query_1698070712_7;
    EntityQuery __query_1698070712_8;
    EntityQuery __query_1698070712_9;
    EntityQuery __query_1698070712_10;
    EntityQuery __query_1698070712_11;
    EntityQuery __query_1698070712_12;
    EntityQuery __query_1698070712_13;
    EntityQuery __query_1698070712_14;
    EntityQuery __query_1698070712_15;
    EntityQuery __query_1698070712_16;
    EntityQuery __query_1698070712_17;
    EntityQuery __query_1698070712_18;
    EntityQuery __query_1698070712_19;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1698070712_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleArenaBlock>(),
            },
        });
        
        __query_1698070712_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.CastleBuilding.PlannedTileModel>(),
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CreateTileModelSelection>(),
            },
        });
        
        __query_1698070712_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.EditTileModelSelection>(),
                ComponentType.ReadWrite<ProjectM.CastleBuilding.PlannedTileModel>(),
            },
        });
        
        __query_1698070712_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.CastleBuilding.PlannedArenaBlock>(),
            },
        });
        
        __query_1698070712_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.CastleBuilding.PlannedInventoryRoute>(),
            },
        });
        
        __query_1698070712_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.PlannedTileModel>(),
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CreateTileModelSelection>(),
            },
        });
        
        __query_1698070712_6 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.EditTileModelSelection>(),
                ComponentType.ReadOnly<ProjectM.CastleBuilding.PlannedTileModel>(),
            },
        });
        
        __query_1698070712_7 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.HoverTileModelSelection>(),
            },
        });
        
        __query_1698070712_8 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.ArenaOperation>(),
                ComponentType.ReadOnly<ProjectM.CastleBuilding.PlannedArenaBlock>(),
            },
        });
        
        __query_1698070712_9 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.PlannedInventoryRoute>(),
                ComponentType.ReadWrite<ProjectM.CastleBuilding.InventoryRouteOperation>(),
            },
        });
        
        __query_1698070712_10 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.BuildMode>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1698070712_11 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.GameDatas>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1698070712_12 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Tiles.TileWorldSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1698070712_13 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Physics.PhysicsWorldSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1698070712_14 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Tiles.TileWorldSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1698070712_15 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.SyncedServerDebugSettings>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1698070712_16 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.BuildModeSettings>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1698070712_17 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Haptics.HapticBuildModeFeedback>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1698070712_18 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Contest.ContestRenderSettings>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1698070712_19 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.InventoryRouteSingleton_Client>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
