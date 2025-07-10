using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToChunkLoadedGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ChunkDataRemappingManager_SetupMapIconRemappings : SystemBase
{
    EntityQuery __query_1432921754_0;
    EntityQuery __query_1432921754_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1432921754_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.WorldAssetSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_1432921754_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ChunkDataRemappings>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
