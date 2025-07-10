using Unity.Entities;

namespace ProjectM.Presentation;


[UpdateInGroup(typeof(ProjectM.PrefabInitializationGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class AimWorldTargetPreviewAssetSystem : SystemBase
{
    EntityQuery __query_1143347545_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_1143347545_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Presentation.AimWorldTargetComponent>(),
                ComponentType.ReadOnly<Stunlock.Core.RegisterPrefabEvent>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeSpawnTag | EntityQueryOptions.IncludeDestroyTag | EntityQueryOptions.IncludeAll,
        });
        
    }
    

}
