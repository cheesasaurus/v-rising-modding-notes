using Unity.Entities;

namespace ProjectM.Shared;


[UpdateInGroup(typeof(ProjectM.PrefabInitializationGroup))]
[UpdateAfter(typeof(ProjectM.PrefabCollectionSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class SpellModCollectionSystem : SystemBase
{
    EntityQuery __query_1853923554_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1853923554_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Shared.SpellModBlobReference>(),
                ComponentType.ReadOnly<Stunlock.Core.RegisterPrefabEvent>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeSpawnTag | EntityQueryOptions.IncludeDestroyTag | EntityQueryOptions.IncludeAll,
        });
        
    }
    

}
