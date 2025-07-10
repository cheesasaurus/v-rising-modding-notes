using Unity.Entities;

namespace ProjectM.CastleBuilding;


[UpdateInGroup(typeof(ProjectM.ReactToChunkLoadedGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class CastleTerritoryHeightsSystem : SystemBase
{
    EntityQuery _ChunkLoadedQuery;
    EntityQuery _QueuedChunkLoadedQuery;
    EntityQuery __query_1402690088_0;
    EntityQuery __query_1402690088_1;
    EntityQuery __query_1402690088_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _ChunkLoadedQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Terrain.TerrainChunkLoadedEvent>(),
            },
        });
        
        _QueuedChunkLoadedQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.CastleBuilding.CastleTerritoryHeightsSystem.QueuedTerrainChunkLoadedEvent>(),
            },
        });
        
        __query_1402690088_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleTerritory>(),
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleTerritoryTiles>(),
            },
        });
        
        __query_1402690088_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.WorldAssetSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1402690088_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainChunkLookup>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
