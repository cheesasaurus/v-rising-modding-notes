using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.PrefabInitializationGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ProgressionDependencySystem : SystemBase
{
    EntityQuery __query_1493368128_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1493368128_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.RegisterPrefab>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeAll,
        });
        
    }
    

}
