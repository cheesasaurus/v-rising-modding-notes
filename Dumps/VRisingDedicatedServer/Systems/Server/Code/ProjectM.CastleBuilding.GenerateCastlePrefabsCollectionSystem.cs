using Unity.Entities;

namespace ProjectM.CastleBuilding;


[UpdateInGroup(typeof(ProjectM.PrefabInitializationGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class GenerateCastlePrefabsCollectionSystem : SystemBase
{
    EntityQuery __query_422246967_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_422246967_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Core.RegisterPrefab>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeSpawnTag | EntityQueryOptions.IncludeDestroyTag | EntityQueryOptions.IncludeAll,
        });
        
    }
    

}
