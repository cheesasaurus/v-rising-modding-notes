using Unity.Entities;

namespace ProjectM.Shared.Systems;


[UpdateInGroup(typeof(ProjectM.PrefabInitializationGroup), OrderLast = true)]
[RequireMatchingQueriesForUpdateAttribute]
public class RegisterPrefabEventsCleanupSystem : SystemBase
{
    EntityQuery _RegisterEventNonBlobOwnerQuery;
    EntityQuery _RegisterEventBlobOwnerQuery;
    EntityQuery _RegisterInheritanceQuery;
    EntityQuery _NewPrefabsRegisteredQuery;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _RegisterEventNonBlobOwnerQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.RegisterPrefabEvent>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<Unity.Entities.BlobAssetOwner>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeSpawnTag | EntityQueryOptions.IncludeDestroyTag | EntityQueryOptions.IncludeAll,
        });
        
        _RegisterEventBlobOwnerQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.RegisterPrefabEvent>(),
                ComponentType.ReadOnly<Unity.Entities.BlobAssetOwner>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeSpawnTag | EntityQueryOptions.IncludeDestroyTag | EntityQueryOptions.IncludeAll,
        });
        
        _RegisterInheritanceQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.RegisterPrefabInheritance>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeSpawnTag | EntityQueryOptions.IncludeDestroyTag | EntityQueryOptions.IncludeAll,
        });
        
        _NewPrefabsRegisteredQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<Stunlock.Core.NewPrefabsRegisteredEvent>(),
            },
        });
        
    }
    

}
