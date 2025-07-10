using Unity.Entities;

namespace ProjectM.CastleBuilding.Systems;


[UpdateInGroup(typeof(ProjectM.ReactToPersistenceLoadedGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class CastleRailingsRegisterOnPersistenceLoad : SystemBase
{
    EntityQuery _RegisterQuery;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _RegisterQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CastleBuilding.CastleRailing>(),
                ComponentType.ReadOnly<ProjectM.TileData>(),
                ComponentType.ReadOnly<ProjectM.TilePosition>(),
                ComponentType.ReadOnly<ProjectM.PersistenceV2.LoadedTag>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeSpawnTag | EntityQueryOptions.IncludeAll,
        });
        
    }
    

}
