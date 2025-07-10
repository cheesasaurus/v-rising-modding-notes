using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToPersistenceLoadedGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class AttachSystem_ReactToPersistenceLoad : ProjectM.AttachSystemBase
{
    EntityQuery _LoadedTagQuery;
    EntityQuery __query_1229206188_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _LoadedTagQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.PersistenceV2.LoadedTag>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeSpawnTag | EntityQueryOptions.IncludeDestroyTag | EntityQueryOptions.IncludeAll,
        });
        
        __query_1229206188_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Attach>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Attached>(),
                ComponentType.ReadOnly<ProjectM.DisabledWaitingForSync>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeSpawnTag | EntityQueryOptions.IncludeAll,
        });
        
    }
    

}
