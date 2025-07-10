using Unity.Entities;

namespace ProjectM.Terrain;


[UpdateInGroup(typeof(ProjectM.ReactToSceneLoadedGroup))]
[UpdateBefore(typeof(ProjectM.Terrain.TerrainManager))]
[RequireMatchingQueriesForUpdateAttribute]
public class WorldInitializationSystem : SystemBase
{
    EntityQuery _WorldSetupQuery;
    EntityQuery __query_288434877_0;
    EntityQuery __query_288434877_1;
    EntityQuery __query_288434877_2;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _WorldSetupQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.WorldConfigSingleton>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.WorldInitializationSystem.Initialized>(),
            },
        });
        
        __query_288434877_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.WorldAssetSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_288434877_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.TerrainManager.SystemData>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_288434877_2 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Terrain.WorldConfigSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
