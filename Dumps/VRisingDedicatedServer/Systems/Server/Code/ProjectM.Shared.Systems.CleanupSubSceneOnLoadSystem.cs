using Unity.Entities;

namespace ProjectM.Shared.Systems;


[UpdateInGroup(typeof(ProjectM.ReactToSceneLoadedGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class CleanupSubSceneOnLoadSystem : SystemBase
{
    EntityQuery _PublicEntityRefQuery;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _PublicEntityRefQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Scenes.PublicEntityRef>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeSpawnTag | EntityQueryOptions.IncludeDestroyTag | EntityQueryOptions.IncludeAll,
        });
        
    }
    

}
