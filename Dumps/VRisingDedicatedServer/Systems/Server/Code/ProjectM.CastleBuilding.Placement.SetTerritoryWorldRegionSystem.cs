using Unity.Entities;

namespace ProjectM.CastleBuilding.Placement;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class SetTerritoryWorldRegionSystem : SystemBase
{
    EntityQuery _GetWorldRegionQuery;
    EntityQuery _CastleTerritoryQuery;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _GetWorldRegionQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.WorldRegionPolygon>(),
                ComponentType.ReadOnly<ProjectM.Terrain.WorldRegionPolygonVertex>(),
            },
        });
        
        _CastleTerritoryQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleTerritory>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.TerritoryWorldRegion>(),
            },
        });
        
    }
    

}
