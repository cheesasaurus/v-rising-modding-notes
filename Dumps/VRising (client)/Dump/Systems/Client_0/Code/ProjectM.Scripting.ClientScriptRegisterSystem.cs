using Unity.Entities;

namespace ProjectM.Scripting;


[UpdateInGroup(typeof(InitializationSystemGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class ClientScriptRegisterSystem : SystemBase
{
    EntityQuery _Query;
    EntityQuery __query_949122721_0;
    
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
        
        __query_949122721_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Scripting.InitializeGameplayScriptsEvent>(),
                ComponentType.ReadOnly<ProjectM.Scripting.HashedTypesBuffer>(),
            },
            Options = EntityQueryOptions.IncludePrefab | EntityQueryOptions.IncludeSpawnTag | EntityQueryOptions.IncludeAll,
        });
        
    }
    

}
