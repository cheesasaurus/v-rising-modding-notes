using Unity.Entities;

namespace ProjectM.CastleBuilding;


[UpdateInGroup(typeof(ProjectM.ReactToTileBoundsGroup))]
[UpdateBefore(typeof(ProjectM.CastleBuilding.CastleFloorAndWallsUpdateSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class CastleEventsOnChunkLoadedSystem : SystemBase
{
    EntityQuery __query_1665006306_0;
    EntityQuery __query_1665006306_1;
    EntityQuery __query_1665006306_2;
    EntityQuery __query_1665006306_3;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1665006306_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainChunkLoadedEvent>(),
            },
        });
        
        __query_1665006306_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleFloor>(),
                ComponentType.ReadOnly<ProjectM.TilePosition>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_1665006306_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleRoomWall>(),
                ComponentType.ReadOnly<ProjectM.TilePosition>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
        __query_1665006306_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.TilePosition>(),
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleWallPillar>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
    }
    

}
