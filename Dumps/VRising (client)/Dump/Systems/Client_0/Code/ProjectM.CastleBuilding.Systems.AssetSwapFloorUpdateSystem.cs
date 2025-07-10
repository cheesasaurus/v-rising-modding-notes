using Unity.Entities;

namespace ProjectM.CastleBuilding.Systems;


[UpdateInGroup(typeof(ProjectM.BeforeSerializeBarrierGroup))]
[UpdateBefore(typeof(ProjectM.CastleBuilding.Systems.AssetSwappingSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class AssetSwapFloorUpdateSystem : SystemBase
{
    EntityQuery _FloorEntityEventQuery;
    EntityQuery _WallEntityEventQuery;
    EntityQuery _PillarEntityEventQuery;
    EntityQuery _WallpaperQuery;
    EntityQuery __query_960380218_0;
    EntityQuery __query_960380218_1;
    EntityQuery __query_960380218_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _FloorEntityEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.EntityAddRemoveUpdateEvents<ProjectM.CastleBuilding.CastleFloor, ProjectM.TilePosition>.EntityEvent>(), // ProjectM.EntityAddRemoveUpdateEvents`2+EntityEvent[[ProjectM.CastleBuilding.CastleFloor, ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[ProjectM.TilePosition, ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]
            },
        });
        
        _WallEntityEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.EntityAddRemoveUpdateEvents<ProjectM.CastleBuilding.CastleRoomWall, ProjectM.TilePosition>.EntityEvent>(), // ProjectM.EntityAddRemoveUpdateEvents`2+EntityEvent[[ProjectM.CastleBuilding.CastleRoomWall, ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[ProjectM.TilePosition, ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]
            },
        });
        
        _PillarEntityEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.EntityAddRemoveUpdateEvents<ProjectM.CastleBuilding.CastleWallPillar, ProjectM.TilePosition>.EntityEvent>(), // ProjectM.EntityAddRemoveUpdateEvents`2+EntityEvent[[ProjectM.CastleBuilding.CastleWallPillar, ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[ProjectM.TilePosition, ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]
            },
        });
        
        _WallpaperQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.AssetSwapping.WallpaperUpdatedEvent>(),
            },
        });
        
        __query_960380218_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.AssetSwapping.WallpaperUpdatedEvent>(),
            },
        });
        
        __query_960380218_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Tiles.TileWorldSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_960380218_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleBlockCollection>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
