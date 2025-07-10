using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToPersistenceLoadedGroup))]
[UpdateAfter(typeof(ProjectM.SetupLocalToWorldOnLoadSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class StaticHierarchySystem_OnPersistenceLoad : SystemBase
{
    EntityQuery _Query;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.StaticHierarchyData>(),
                ComponentType.ReadWrite<Unity.Transforms.LocalToWorld>(),
                ComponentType.ReadOnly<ProjectM.StaticHierarchyBuffer>(),
                ComponentType.ReadOnly<ProjectM.PersistenceV2.LoadedTag>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeSpawnTag | EntityQueryOptions.IncludeDestroyTag | EntityQueryOptions.IncludeAll,
        });
        
    }
    

}
