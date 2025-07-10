using Unity.Entities;

namespace ProjectM.Shared.Systems;


[UpdateInGroup(typeof(ProjectM.ReactToSceneLoadedGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class DefragMemoryOnSubSceneLoadSystem : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_2059474518_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Entities.RequestSceneLoaded>(),
                ComponentType.ReadOnly<Unity.Scenes.IsSectionLoaded>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Shared.Systems.DefragMemoryOnSubSceneLoadSystem.DefragOnSceneLoadProcessed>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeSpawnTag | EntityQueryOptions.IncludeDestroyTag | EntityQueryOptions.IncludeAll,
        });
        
        __query_2059474518_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Entities.RequestSceneLoaded>(),
                ComponentType.ReadOnly<Unity.Scenes.IsSectionLoaded>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Shared.Systems.DefragMemoryOnSubSceneLoadSystem.DefragOnSceneLoadProcessed>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeSpawnTag | EntityQueryOptions.IncludeDestroyTag | EntityQueryOptions.IncludeAll,
        });
        
    }
    

}
