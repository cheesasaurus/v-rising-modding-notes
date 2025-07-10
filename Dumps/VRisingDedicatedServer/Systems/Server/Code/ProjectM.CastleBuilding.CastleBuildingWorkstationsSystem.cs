using Unity.Entities;

namespace ProjectM.CastleBuilding;


[UpdateInGroup(typeof(ProjectM.ReactToTileBoundsGroup))]
[UpdateAfter(typeof(ProjectM.CastleBuilding.RoomRoofUpdateSystem))]
[UpdateAfter(typeof(ProjectM.CastleBuilding.CastleBuildingSearchRoomSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class CastleBuildingWorkstationsSystem : SystemBase
{
    EntityQuery _AddedFloorsQuery;
    EntityQuery _MovedFloorsQuery;
    EntityQuery _AddedWorkstationsQuery;
    EntityQuery _MovedWorkstationsQuery;
    EntityQuery _RemovedWorkstationsQuery;
    EntityQuery _HandleRoomEventsQuery;
    EntityQuery _RecalculateWorkstationLevelQuery;
    
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
        
        _AddedWorkstationsQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityAddRemoveUpdateEvents<ProjectM.CastleWorkstation, ProjectM.TilePosition>.EntityEvent>(), // ProjectM.EntityAddRemoveUpdateEvents`2+EntityEvent[[ProjectM.CastleWorkstation, ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[ProjectM.TilePosition, ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]
                ComponentType.ReadOnly<ProjectM.EntityAddRemoveUpdateEvents<ProjectM.CastleWorkstation, ProjectM.TilePosition>.AddedEvent>(), // ProjectM.EntityAddRemoveUpdateEvents`2+AddedEvent[[ProjectM.CastleWorkstation, ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[ProjectM.TilePosition, ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]
            },
        });
        
        _MovedWorkstationsQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityAddRemoveUpdateEvents<ProjectM.CastleWorkstation, ProjectM.TilePosition>.EntityEvent>(), // ProjectM.EntityAddRemoveUpdateEvents`2+EntityEvent[[ProjectM.CastleWorkstation, ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[ProjectM.TilePosition, ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]
                ComponentType.ReadOnly<ProjectM.EntityAddRemoveUpdateEvents<ProjectM.CastleWorkstation, ProjectM.TilePosition>.UpdatedEvent>(), // ProjectM.EntityAddRemoveUpdateEvents`2+UpdatedEvent[[ProjectM.CastleWorkstation, ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[ProjectM.TilePosition, ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]
            },
        });
        
        _RemovedWorkstationsQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityAddRemoveUpdateEvents<ProjectM.CastleWorkstation, ProjectM.TilePosition>.EntityEvent>(), // ProjectM.EntityAddRemoveUpdateEvents`2+EntityEvent[[ProjectM.CastleWorkstation, ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[ProjectM.TilePosition, ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]
                ComponentType.ReadOnly<ProjectM.EntityAddRemoveUpdateEvents<ProjectM.CastleWorkstation, ProjectM.TilePosition>.RemovedEvent>(), // ProjectM.EntityAddRemoveUpdateEvents`2+RemovedEvent[[ProjectM.CastleWorkstation, ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[ProjectM.TilePosition, ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]
            },
        });
        
        _HandleRoomEventsQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleRoomEvent>(),
            },
        });
        
        _RecalculateWorkstationLevelQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.CastleWorkstation>(),
                ComponentType.ReadOnly<ProjectM.Shared.CastleWorkstationRecalculateLevel>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.DisabledWaitingForTransform>(),
                ComponentType.ReadOnly<ProjectM.Network.DisabledDueToTimeout>(),
                ComponentType.ReadOnly<ProjectM.Tiles.DisabledTileModel>(),
                ComponentType.ReadOnly<Unity.Entities.DestroyTag>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
    }
    

}
