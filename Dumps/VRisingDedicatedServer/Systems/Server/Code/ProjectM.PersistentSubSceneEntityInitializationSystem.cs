using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSceneLoadedGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class PersistentSubSceneEntityInitializationSystem : SystemBase
{
    EntityQuery _PersistentSubSceneObjectQuery;
    EntityQuery __query_1488898736_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _PersistentSubSceneObjectQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Entities.StaticSceneTag>(),
                ComponentType.ReadOnly<ProjectM.PersistenceV2.StoreSubSceneEntity>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeSpawnTag | EntityQueryOptions.IncludeDestroyTag | EntityQueryOptions.IncludeAll,
        });
        
        __query_1488898736_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.PersistenceV2.MissingStoreSubSceneEntity>(),
            },
        });
        
    }
    

}
