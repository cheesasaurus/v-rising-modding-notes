using Unity.Entities;

namespace ProjectM.Terrain;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class TerritoryManagerSpawnSystem : SystemBase
{
    EntityQuery _CastleTerritoryQuery;
    EntityQuery _ReactToSpawnedQuery;
    EntityQuery __query_1606139178_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _CastleTerritoryQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleTerritory>(),
                ComponentType.ReadOnly<ProjectM.Terrain.MapZoneData>(),
            },
        });
        
        _ReactToSpawnedQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.CastleBuilding.CastleTerritoryOccupant>(),
                ComponentType.ReadWrite<ProjectM.CastleBuilding.CastleTerritoryDecay>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
        __query_1606139178_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.CastleBuilding.CastleTerritoryOccupant>(),
                ComponentType.ReadWrite<ProjectM.CastleBuilding.CastleTerritoryDecay>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
        });
        
    }
    

}
