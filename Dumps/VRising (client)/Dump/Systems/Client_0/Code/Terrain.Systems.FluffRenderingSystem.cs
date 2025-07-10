using Unity.Entities;

namespace Terrain.Systems;


[UpdateInGroup(typeof(ProjectM.FluffGroup))]
public class FluffRenderingSystem : SystemBase
{
    EntityQuery _UnloadedFluffQuery;
    EntityQuery __query_1016258907_0;
    EntityQuery __query_1016258907_1;
    EntityQuery __query_1016258907_2;
    EntityQuery __query_1016258907_3;
    EntityQuery __query_1016258907_4;
    EntityQuery __query_1016258907_5;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _UnloadedFluffQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Terrain.Systems.FluffChunkPoolAllocation>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.ChunkFluffTransformation>(),
                ComponentType.ReadOnly<ProjectM.Terrain.PerChunkFluffDataComponent>(),
            },
        });
        
        __query_1016258907_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Terrain.Systems.FluffChunkPoolAllocation>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.ChunkFluffTransformation>(),
                ComponentType.ReadOnly<ProjectM.Terrain.PerChunkFluffDataComponent>(),
            },
        });
        
        __query_1016258907_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.FluffDataBlob>(),
                ComponentType.ReadOnly<ProjectM.Terrain.ChunkFluffTransformation>(),
                ComponentType.ReadOnly<ProjectM.Terrain.PerChunkFluffDataComponent>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Terrain.Systems.FluffChunkPoolAllocation>(),
            },
        });
        
        __query_1016258907_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.ChunkFluffTransformation>(),
                ComponentType.ReadOnly<Terrain.Systems.FluffChunkPoolAllocation>(),
            },
        });
        
        __query_1016258907_3 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.ChunkFluffTransformation>(),
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainChunk>(),
                ComponentType.ReadOnly<Terrain.Systems.FluffChunkPoolAllocation>(),
                ComponentType.ReadOnly<ProjectM.Terrain.PerChunkFluffDataComponent>(),
            },
        });
        
        __query_1016258907_4 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.DisableFluffSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1016258907_5 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.HybridCameraData>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
