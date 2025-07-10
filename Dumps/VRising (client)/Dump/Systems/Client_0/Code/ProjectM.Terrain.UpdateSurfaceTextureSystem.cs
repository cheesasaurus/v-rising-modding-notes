using Unity.Entities;

namespace ProjectM.Terrain;


[UpdateInGroup(typeof(ProjectM.FluffGroup))]
[UpdateAfter(typeof(ProjectM.Terrain.SurfaceTextureBarrier))]
[RequireMatchingQueriesForUpdateAttribute]
public class UpdateSurfaceTextureSystem : SystemBase
{
    EntityQuery _RecalculateQuery;
    EntityQuery _CameraUserQuery;
    EntityQuery _TerrainChunkQuery;
    EntityQuery __query_1669522688_0;
    EntityQuery __query_1669522688_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _RecalculateQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Terrain.RecalculateSurfaceColorsEvent>(),
            },
        });
        
        _CameraUserQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.CameraUser>(),
            },
        });
        
        _TerrainChunkQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainChunk>(),
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainTag>(),
            },
        });
        
        __query_1669522688_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.HybridCameraData>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1669522688_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainChunkLookup>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
