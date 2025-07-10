using Unity.Entities;

namespace ProjectM.CastleBuilding.Systems;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class CastleRailingsSystem : SystemBase
{
    EntityQuery _FloorEntityEventQuery;
    EntityQuery _WallEntityEventQuery;
    EntityQuery _PillarEntityEventQuery;
    EntityQuery _RegisterRailingsQuery;
    EntityQuery __query_1415284963_0;
    EntityQuery __query_1415284963_1;
    EntityQuery __query_1415284963_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _FloorEntityEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityAddRemoveUpdateEvents<ProjectM.CastleBuilding.CastleFloor, ProjectM.TilePosition>.EntityEvent>(), // ProjectM.EntityAddRemoveUpdateEvents`2+EntityEvent[[ProjectM.CastleBuilding.CastleFloor, ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[ProjectM.TilePosition, ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]
            },
        });
        
        _WallEntityEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityAddRemoveUpdateEvents<ProjectM.CastleBuilding.CastleRoomWall, ProjectM.TilePosition>.EntityEvent>(), // ProjectM.EntityAddRemoveUpdateEvents`2+EntityEvent[[ProjectM.CastleBuilding.CastleRoomWall, ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[ProjectM.TilePosition, ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]
            },
        });
        
        _PillarEntityEventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.EntityAddRemoveUpdateEvents<ProjectM.CastleBuilding.CastleWallPillar, ProjectM.TilePosition>.EntityEvent>(), // ProjectM.EntityAddRemoveUpdateEvents`2+EntityEvent[[ProjectM.CastleBuilding.CastleWallPillar, ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null],[ProjectM.TilePosition, ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null]]
            },
        });
        
        _RegisterRailingsQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleRailing>(),
                ComponentType.ReadOnly<ProjectM.TileData>(),
                ComponentType.ReadOnly<ProjectM.TilePosition>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
            Options = EntityQueryOptions.IncludeSpawnTag | EntityQueryOptions.IncludeAll,
        });
        
        __query_1415284963_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleBlockCollection>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1415284963_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.PrefabLookupMap>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1415284963_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Tiles.TileWorldSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
