using Unity.Entities;

namespace ProjectM.Shared.Systems;


[UpdateInGroup(typeof(ProjectM.PrefabInitializationGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ServerScriptRegisterSystem : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_1231292083_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Scripting.InitializeGameplayScriptsEvent>(),
                ComponentType.ReadOnly<ProjectM.Scripting.HashedTypesBuffer>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeSpawnTag | EntityQueryOptions.IncludeAll,
        });
        
        __query_1231292083_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Scripting.InitializeGameplayScriptsEvent>(),
                ComponentType.ReadOnly<ProjectM.Scripting.HashedTypesBuffer>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeSpawnTag | EntityQueryOptions.IncludeAll,
        });
        
    }
    

}
