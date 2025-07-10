using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(InitializationSystemGroup))]
[UpdateAfter(typeof(Unity.Scenes.SceneSystemGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class UISpawningSystem : SystemBase
{
    EntityQuery _UIToSpawnQuery;
    EntityQuery _ExistingSpawnedQuery;
    EntityQuery __query_549421530_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _UIToSpawnQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.SpawnUIPrefabOnLoad>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UI.UISpawningSystem.Spawned>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeAll,
        });
        
        _ExistingSpawnedQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UI.UISpawningSystem.Spawned>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeAll,
        });
        
        __query_549421530_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.UI.SpawnUIPrefabOnLoad>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.UI.UISpawningSystem.Spawned>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeAll,
        });
        
    }
    

}
