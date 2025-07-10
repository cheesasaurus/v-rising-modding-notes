using Unity.Entities;

namespace ProjectM.Gameplay.Systems;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[UpdateAfter(typeof(ProjectM.Gameplay.Systems.CastleHeartDetectRaidSystem))]
public class CastleHeartUpdateRaidStateSystem : SystemBase
{
    EntityQuery _RaidStateUpdateEvent;
    EntityQuery __query_1288933524_0;
    EntityQuery __query_1288933524_1;
    EntityQuery __query_1288933524_2;
    EntityQuery __query_1288933524_3;
    EntityQuery __query_1288933524_4;
    EntityQuery __query_1288933524_5;
    EntityQuery __query_1288933524_6;
    EntityQuery __query_1288933524_7;
    EntityQuery __query_1288933524_8;
    EntityQuery __query_1288933524_9;
    EntityQuery __query_1288933524_10;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _RaidStateUpdateEvent = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Gameplay.Systems.CastleHeartsRaidStateEvent>(),
            },
        });
        
        __query_1288933524_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleHeartConnection>(),
                ComponentType.ReadOnly<ProjectM.BuffableFlagState>(),
                ComponentType.ReadOnly<ProjectM.Tiles.TileModel>(),
                ComponentType.ReadOnly<ProjectM.CastleBuilding.ImmaterialWhileRaided>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_1288933524_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleHeartConnection>(),
                ComponentType.ReadOnly<ProjectM.Health>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleHeart>(),
                ComponentType.ReadOnly<ProjectM.CastleBuilding.ImmaterialWhileRaided>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_1288933524_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleHeartConnection>(),
                ComponentType.ReadOnly<ProjectM.CastleBuilding.SwapArtWhileRaidedRoot>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_1288933524_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.MapIconTargetEntity>(),
                ComponentType.ReadOnly<ProjectM.SpawnLocationSelector>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_1288933524_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.RespawnPointOwnerBuffer>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_1288933524_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleHeartConnection>(),
                ComponentType.ReadOnly<ProjectM.ChunkWaypoint>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_1288933524_6 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.WaypointMapIcon>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_1288933524_7 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Gameplay.Systems.CastleHeartsRaidStateEvent>(),
            },
        });
        
        __query_1288933524_8 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ModificationsRegistry>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1288933524_9 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Gameplay.Systems.CastleHeartsRaidState>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1288933524_10 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.NetworkIdSystem.Singleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
