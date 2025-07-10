using Unity.Entities;

namespace ProjectM.Haptics;


[UpdateInGroup(typeof(ProjectM.PrefabInitializationGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class AdaptiveTriggerSingletonSystem : SystemBase
{
    EntityQuery __query_1934787295_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1934787295_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.RegisterPrefab>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeAll,
        });
        
    }
    

}
