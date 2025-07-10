using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.UIGroup))]
[UpdateAfter(typeof(ProjectM.UI.MapZonePolygonUIMeshSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class MapMenuMapper : SystemBase, ProjectM.IInputContext
{
    EntityQuery _Query;
    EntityQuery _DisableSendAimInputQuery;
    EntityQuery _ResetMovementCameraDirectionQuery;
    EntityQuery _ResponseEntityQuery;
    EntityQuery __query_731849343_0;
    EntityQuery __query_731849343_1;
    EntityQuery __query_731849343_2;
    EntityQuery __query_731849343_3;
    EntityQuery __query_731849343_4;
    EntityQuery __query_731849343_5;
    EntityQuery __query_731849343_6;
    EntityQuery __query_731849343_7;
    EntityQuery __query_731849343_8;
    EntityQuery __query_731849343_9;
    EntityQuery __query_731849343_10;
    EntityQuery __query_731849343_11;
    EntityQuery __query_731849343_12;
    EntityQuery __query_731849343_13;
    EntityQuery __query_731849343_14;
    EntityQuery __query_731849343_15;
    EntityQuery __query_731849343_16;
    EntityQuery __query_731849343_17;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.MapMenu>(),
            },
        });
        
        _DisableSendAimInputQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.DisableSendAimInput>(),
            },
        });
        
        _ResetMovementCameraDirectionQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.ResetMovementCameraDirection>(),
            },
        });
        
        _ResponseEntityQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.RecommendedSpawnLocationResponseEvent>(),
                ComponentType.ReadOnly<ProjectM.Network.ReceiveNetworkEventTag>(),
            },
        });
        
        __query_731849343_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.MapMenu>(),
            },
        });
        
        __query_731849343_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Shared.WarEvents.WarEvent_NetworkedData>(),
            },
        });
        
        __query_731849343_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UI.UiPolygonMesh>(),
                ComponentType.ReadOnly<ProjectM.Terrain.MapZoneData>(),
                ComponentType.ReadWrite<ProjectM.Terrain.MapZonePolygonVertexElement>(),
                ComponentType.ReadOnly<ProjectM.Terrain.MapZoneDiscoverableElement>(),
            },
        });
        
        __query_731849343_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleTerritory>(),
                ComponentType.ReadOnly<ProjectM.Terrain.MapZoneData>(),
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleTerritoryTiles>(),
            },
        });
        
        __query_731849343_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.RecommendedSpawnLocationResponseEvent>(),
                ComponentType.ReadOnly<ProjectM.Network.ReceiveNetworkEventTag>(),
            },
        });
        
        __query_731849343_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Shared.WarEvents.WarEvent_NetworkedGate>(),
            },
        });
        
        __query_731849343_6 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleTerritory>(),
                ComponentType.ReadOnly<ProjectM.Terrain.MapZoneData>(),
            },
        });
        
        __query_731849343_7 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<ProjectM.Terrain.MapRegionNameComponent>(),
            },
        });
        
        __query_731849343_8 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<ProjectM.Terrain.WarEventInfoEntryPosition>(),
            },
        });
        
        __query_731849343_9 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.MapIconData>(),
                ComponentType.ReadOnly<Unity.Transforms.Rotation>(),
                ComponentType.ReadOnly<Unity.Transforms.Translation>(),
                ComponentType.ReadOnly<Stunlock.Core.PrefabGUID>(),
            },
        });
        
        __query_731849343_10 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.WorldZoneId>(),
            },
        });
        
        __query_731849343_11 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainChunkLookup>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_731849343_12 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleTerritoryManager>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_731849343_13 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerGameBalanceSettings>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_731849343_14 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.TimeZonedDateTime>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_731849343_15 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.RootPrefabCollection>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_731849343_16 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerTime>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_731849343_17 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.LocalControlled>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
