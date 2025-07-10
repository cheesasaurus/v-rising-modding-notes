using Unity.Entities;

namespace ProjectM.CastleBuilding;


[UpdateInGroup(typeof(ProjectM.ReactToTileBoundsGroup))]
[UpdateAfter(typeof(ProjectM.CastleBuilding.CastleBuildingSearchRoomSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class RoomRoofUpdateSystem : SystemBase
{
    EntityQuery _DestroyedRoomsQuery;
    EntityQuery _RoomEventQuery;
    EntityQuery _NewFloorsQuery;
    EntityQuery _MovedFloorsQuery;
    EntityQuery _DestroyedFloorsQuery;
    EntityQuery _NewWallsQuery;
    EntityQuery _DestroyedWallsQuery;
    EntityQuery __query_927812751_0;
    EntityQuery __query_927812751_1;
    EntityQuery __query_927812751_2;
    EntityQuery __query_927812751_3;
    EntityQuery __query_927812751_4;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _DestroyedRoomsQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleRoom>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
        _RoomEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleRoomEvent>(),
            },
        });
        
        _NewFloorsQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityAddRemoveUpdateEvents<ProjectM.CastleBuilding.CastleFloor, ProjectM.TilePosition>.AddedEvent>(), // ProjectM.EntityAddRemoveUpdateEvents`2+AddedEvent[[ProjectM.CastleBuilding.CastleFloor, ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[ProjectM.TilePosition, ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]
            },
        });
        
        _MovedFloorsQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityAddRemoveUpdateEvents<ProjectM.CastleBuilding.CastleFloor, ProjectM.TilePosition>.UpdatedEvent>(), // ProjectM.EntityAddRemoveUpdateEvents`2+UpdatedEvent[[ProjectM.CastleBuilding.CastleFloor, ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[ProjectM.TilePosition, ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]
            },
        });
        
        _DestroyedFloorsQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityAddRemoveUpdateEvents<ProjectM.CastleBuilding.CastleFloor, ProjectM.TilePosition>.RemovedEvent>(), // ProjectM.EntityAddRemoveUpdateEvents`2+RemovedEvent[[ProjectM.CastleBuilding.CastleFloor, ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[ProjectM.TilePosition, ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]
            },
        });
        
        _NewWallsQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityAddRemoveUpdateEvents<ProjectM.CastleBuilding.CastleRoomWall, ProjectM.TilePosition>.EntityEvent>(), // ProjectM.EntityAddRemoveUpdateEvents`2+EntityEvent[[ProjectM.CastleBuilding.CastleRoomWall, ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[ProjectM.TilePosition, ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]
                ComponentType.ReadOnly<ProjectM.EntityAddRemoveUpdateEvents<ProjectM.CastleBuilding.CastleRoomWall, ProjectM.TilePosition>.AddedEvent>(), // ProjectM.EntityAddRemoveUpdateEvents`2+AddedEvent[[ProjectM.CastleBuilding.CastleRoomWall, ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[ProjectM.TilePosition, ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]
            },
        });
        
        _DestroyedWallsQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityAddRemoveUpdateEvents<ProjectM.CastleBuilding.CastleRoomWall, ProjectM.TilePosition>.EntityEvent>(), // ProjectM.EntityAddRemoveUpdateEvents`2+EntityEvent[[ProjectM.CastleBuilding.CastleRoomWall, ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[ProjectM.TilePosition, ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]
                ComponentType.ReadOnly<ProjectM.EntityAddRemoveUpdateEvents<ProjectM.CastleBuilding.CastleRoomWall, ProjectM.TilePosition>.RemovedEvent>(), // ProjectM.EntityAddRemoveUpdateEvents`2+RemovedEvent[[ProjectM.CastleBuilding.CastleRoomWall, ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[ProjectM.TilePosition, ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]
            },
        });
        
        __query_927812751_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleRoom>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
        });
        
        __query_927812751_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleRoomEvent>(),
            },
        });
        
        __query_927812751_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleRoom>(),
            },
        });
        
        __query_927812751_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleBlockCollection>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_927812751_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.PrefabLookupMap>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
