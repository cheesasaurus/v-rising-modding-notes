using Unity.Entities;

namespace Terrain.Systems;


[UpdateInGroup(typeof(ProjectM.FluffGroup))]
public class FluffRenderingMaskSystem : SystemBase
{
    EntityQuery _UnloadedFluffQuery;
    EntityQuery __query_1967123606_0;
    EntityQuery __query_1967123606_1;
    EntityQuery __query_1967123606_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _UnloadedFluffQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Terrain.Systems.FluffMaskPoolAllocation>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainChunk>(),
                ComponentType.ReadOnly<ProjectM.Terrain.SurfaceFluffAllowance>(),
            },
        });
        
        __query_1967123606_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Terrain.Systems.FluffMaskPoolAllocation>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainChunk>(),
                ComponentType.ReadOnly<ProjectM.Terrain.SurfaceFluffAllowance>(),
            },
        });
        
        __query_1967123606_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainChunk>(),
                ComponentType.ReadOnly<ProjectM.Terrain.SurfaceFluffAllowance>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Terrain.Systems.FluffMaskPoolAllocation>(),
            },
        });
        
        __query_1967123606_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Terrain.Systems.FluffMaskPoolAllocation>(),
                ComponentType.ReadWrite<ProjectM.Terrain.SurfaceFluffAllowance>(),
            },
        });
        
    }
    

}
