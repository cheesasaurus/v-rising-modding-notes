using Unity.Entities;

namespace ProjectM.Shared;


[UpdateInGroup(typeof(ProjectM.PrefabInitializationGroup))]
[UpdateAfter(typeof(ProjectM.PrefabCollectionSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public class SpellModCollectionSystem_UI : SystemBase
{
    EntityQuery __query_1853923589_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1853923589_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Shared.SpellModBlobReference_UI>(),
                ComponentType.ReadOnly<Stunlock.Core.RegisterPrefabEvent>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeSpawnTag | EntityQueryOptions.IncludeDestroyTag | EntityQueryOptions.IncludeAll,
        });
        
    }
    

}
