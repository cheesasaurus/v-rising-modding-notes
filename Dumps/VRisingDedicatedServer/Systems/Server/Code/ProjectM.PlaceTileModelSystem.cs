using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.LateUpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class PlaceTileModelSystem : SystemBase
{
    EntityQuery _BuildTileQuery;
    EntityQuery _StartEditQuery;
    EntityQuery _CancelEditQuery;
    EntityQuery _MoveTileQuery;
    EntityQuery _DismantleTileQuery;
    EntityQuery _ConnectionChangedQuery;
    EntityQuery _AbilityCastFinishedQuery;
    EntityQuery _RepairTileQuery;
    EntityQuery _BuildWallpaperQuery;
    EntityQuery _SetVariationQuery;
    EntityQuery __query_112767830_0;
    EntityQuery __query_112767830_1;
    EntityQuery __query_112767830_2;
    EntityQuery __query_112767830_3;
    EntityQuery __query_112767830_4;
    EntityQuery __query_112767830_5;
    EntityQuery __query_112767830_6;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _BuildTileQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.BuildTileModelEvent>(),
            },
        });
        
        _StartEditQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.StartEditTileModelEvent>(),
            },
        });
        
        _CancelEditQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.CancelEditTileModelEvent>(),
            },
        });
        
        _MoveTileQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.MoveTileModelEvent>(),
            },
        });
        
        _DismantleTileQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.DismantleTileModelEvent>(),
            },
        });
        
        _ConnectionChangedQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UserConnectionChangedEvent>(),
            },
        });
        
        _AbilityCastFinishedQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AbilityPreCastFinishedEvent>(),
            },
        });
        
        _RepairTileQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.RepairTileModelEvent>(),
            },
        });
        
        _BuildWallpaperQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.BuildWallpaperEvent>(),
            },
        });
        
        _SetVariationQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.FromCharacter>(),
                ComponentType.ReadOnly<ProjectM.SetTileModelVariationEvent>(),
            },
        });
        
        __query_112767830_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Physics.PhysicsWorldSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_112767830_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.NetworkIdSystem.Singleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_112767830_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Tiles.TileWorldSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_112767830_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerTime>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_112767830_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.PrefabLookupMap>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_112767830_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.MapZoneCollection>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_112767830_6 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Network.UserActivityGrid>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
