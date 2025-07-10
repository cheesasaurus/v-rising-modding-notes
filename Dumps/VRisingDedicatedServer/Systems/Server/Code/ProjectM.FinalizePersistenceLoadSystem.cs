using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.LoadPersistenceGroup), OrderLast = true)]
public class FinalizePersistenceLoadSystem : ComponentSystemGroup
{
    EntityQuery _LoadedOrInstantiatedTagQuery;
    EntityQuery __query_633484159_0;
    EntityQuery __query_633484159_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _LoadedOrInstantiatedTagQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            Any = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.PersistenceV2.LoadedTag>(),
                ComponentType.ReadOnly<ProjectM.PersistenceV2.InstantiatedOnLoadTag>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeSpawnTag | EntityQueryOptions.IncludeDestroyTag | EntityQueryOptions.IncludeAll,
        });
        
        __query_633484159_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.ServerRuntimeSettings>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
        __query_633484159_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.FinalizePersistenceLoadSystem.KeepDataAfterPersistenceTestSingleton>(),
            },
            Options = EntityQueryOptions.IncludeSystems,
        });
        
    }
    

}
