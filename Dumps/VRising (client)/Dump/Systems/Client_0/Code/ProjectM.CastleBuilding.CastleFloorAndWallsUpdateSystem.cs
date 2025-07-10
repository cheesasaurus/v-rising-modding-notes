using Unity.Entities;

namespace ProjectM.CastleBuilding;


[UpdateInGroup(typeof(ProjectM.ReactToTileBoundsGroup))]
[UpdateAfter(typeof(ProjectM.Tiles.TileModelSpatialLookupSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class CastleFloorAndWallsUpdateSystem : SystemBase
{
    EntityQuery _AddedFloorsQuery;
    EntityQuery _MovedFloorsQuery;
    EntityQuery _RemovedFloorsQuery;
    EntityQuery _AddedWallsQuery;
    EntityQuery _MovedWallsQuery;
    EntityQuery _RemovedWallsQuery;
    EntityQuery __query_952920868_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _AddedFloorsQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityAddRemoveUpdateEvents<ProjectM.CastleBuilding.CastleFloor, ProjectM.TilePosition>.EntityEvent>(), // ProjectM.EntityAddRemoveUpdateEvents`2+EntityEvent[[ProjectM.CastleBuilding.CastleFloor, ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[ProjectM.TilePosition, ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]
                ComponentType.ReadOnly<ProjectM.EntityAddRemoveUpdateEvents<ProjectM.CastleBuilding.CastleFloor, ProjectM.TilePosition>.AddedEvent>(), // ProjectM.EntityAddRemoveUpdateEvents`2+AddedEvent[[ProjectM.CastleBuilding.CastleFloor, ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[ProjectM.TilePosition, ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]
            },
        });
        
        _MovedFloorsQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityAddRemoveUpdateEvents<ProjectM.CastleBuilding.CastleFloor, ProjectM.TilePosition>.EntityEvent>(), // ProjectM.EntityAddRemoveUpdateEvents`2+EntityEvent[[ProjectM.CastleBuilding.CastleFloor, ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[ProjectM.TilePosition, ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]
                ComponentType.ReadOnly<ProjectM.EntityAddRemoveUpdateEvents<ProjectM.CastleBuilding.CastleFloor, ProjectM.TilePosition>.UpdatedEvent>(), // ProjectM.EntityAddRemoveUpdateEvents`2+UpdatedEvent[[ProjectM.CastleBuilding.CastleFloor, ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[ProjectM.TilePosition, ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]
            },
        });
        
        _RemovedFloorsQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityAddRemoveUpdateEvents<ProjectM.CastleBuilding.CastleFloor, ProjectM.TilePosition>.EntityEvent>(), // ProjectM.EntityAddRemoveUpdateEvents`2+EntityEvent[[ProjectM.CastleBuilding.CastleFloor, ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[ProjectM.TilePosition, ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]
                ComponentType.ReadOnly<ProjectM.EntityAddRemoveUpdateEvents<ProjectM.CastleBuilding.CastleFloor, ProjectM.TilePosition>.RemovedEvent>(), // ProjectM.EntityAddRemoveUpdateEvents`2+RemovedEvent[[ProjectM.CastleBuilding.CastleFloor, ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[ProjectM.TilePosition, ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]
            },
        });
        
        _AddedWallsQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityAddRemoveUpdateEvents<ProjectM.CastleBuilding.CastleRoomWall, ProjectM.TilePosition>.EntityEvent>(), // ProjectM.EntityAddRemoveUpdateEvents`2+EntityEvent[[ProjectM.CastleBuilding.CastleRoomWall, ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[ProjectM.TilePosition, ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]
                ComponentType.ReadOnly<ProjectM.EntityAddRemoveUpdateEvents<ProjectM.CastleBuilding.CastleRoomWall, ProjectM.TilePosition>.AddedEvent>(), // ProjectM.EntityAddRemoveUpdateEvents`2+AddedEvent[[ProjectM.CastleBuilding.CastleRoomWall, ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[ProjectM.TilePosition, ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]
            },
        });
        
        _MovedWallsQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityAddRemoveUpdateEvents<ProjectM.CastleBuilding.CastleRoomWall, ProjectM.TilePosition>.EntityEvent>(), // ProjectM.EntityAddRemoveUpdateEvents`2+EntityEvent[[ProjectM.CastleBuilding.CastleRoomWall, ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[ProjectM.TilePosition, ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]
                ComponentType.ReadOnly<ProjectM.EntityAddRemoveUpdateEvents<ProjectM.CastleBuilding.CastleRoomWall, ProjectM.TilePosition>.UpdatedEvent>(), // ProjectM.EntityAddRemoveUpdateEvents`2+UpdatedEvent[[ProjectM.CastleBuilding.CastleRoomWall, ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[ProjectM.TilePosition, ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]
            },
        });
        
        _RemovedWallsQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityAddRemoveUpdateEvents<ProjectM.CastleBuilding.CastleRoomWall, ProjectM.TilePosition>.EntityEvent>(), // ProjectM.EntityAddRemoveUpdateEvents`2+EntityEvent[[ProjectM.CastleBuilding.CastleRoomWall, ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[ProjectM.TilePosition, ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]
                ComponentType.ReadOnly<ProjectM.EntityAddRemoveUpdateEvents<ProjectM.CastleBuilding.CastleRoomWall, ProjectM.TilePosition>.RemovedEvent>(), // ProjectM.EntityAddRemoveUpdateEvents`2+RemovedEvent[[ProjectM.CastleBuilding.CastleRoomWall, ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[ProjectM.TilePosition, ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]
            },
        });
        
        __query_952920868_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Tiles.TileWorldSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
