using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.PrefabInitializationGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class AimAssistConfigurationsSystem : SystemBase
{
    EntityQuery __query_559637168_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_559637168_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AimAssistConfigComponent>(),
                ComponentType.ReadOnly<Stunlock.Core.RegisterPrefabEvent>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeSpawnTag | EntityQueryOptions.IncludeDestroyTag | EntityQueryOptions.IncludeAll,
        });
        
    }
    

}
