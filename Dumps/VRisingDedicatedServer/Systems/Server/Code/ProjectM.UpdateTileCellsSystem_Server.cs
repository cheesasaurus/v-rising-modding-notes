using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToTileBoundsGroup))]
[UpdateAfter(typeof(ProjectM.Tiles.TileModelSpatialLookupSystem))]
public class UpdateTileCellsSystem_Server : ProjectM.UpdateTileCellsSystem
{
    EntityQuery __query_402779724_0;
    EntityQuery __query_402779724_1;
    EntityQuery __query_402779724_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_402779724_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainChunkLookup>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_402779724_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Tiles.TileWorldSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_402779724_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.DirtyTileBoundsManager.Singleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
