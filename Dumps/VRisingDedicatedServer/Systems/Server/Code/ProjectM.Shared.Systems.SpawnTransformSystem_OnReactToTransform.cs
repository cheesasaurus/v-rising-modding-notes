using Unity.Entities;

namespace ProjectM.Shared.Systems;


[UpdateInGroup(typeof(ProjectM.ReactToTransformGroup))]
[UpdateAfter(typeof(ProjectM.ReactToTileBoundsGroup))]
public class SpawnTransformSystem_OnReactToTransform : SystemBase
{
    EntityQuery __query_565030781_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_565030781_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Tiles.TileWorldSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
