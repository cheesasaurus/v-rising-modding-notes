using Unity.Entities;

namespace ProjectM.Terrain;


[UpdateInGroup(typeof(ProjectM.ReactToTileBoundsGroup))]
[UpdateAfter(typeof(ProjectM.Terrain.CalculateDirtyFluffChunksSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class SurfaceTypeUpdateSystem : SystemBase
{
    EntityQuery _EventQuery;
    EntityQuery __query_382831860_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _EventQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.RecalculateSurfaceTypesEvent>(),
            },
        });
        
        __query_382831860_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainChunkLookup>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
