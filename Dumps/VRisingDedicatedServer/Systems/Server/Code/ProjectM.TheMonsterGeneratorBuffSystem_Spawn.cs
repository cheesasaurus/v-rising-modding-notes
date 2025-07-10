using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class TheMonsterGeneratorBuffSystem_Spawn : SystemBase
{
    EntityQuery _BuffQuery;
    EntityQuery __query_666345371_0;
    EntityQuery __query_666345371_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _BuffQuery = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.TheMonsterGeneratorActiveBuff>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.MonsterGeneratorBindingInitialized>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeSpawnTag | EntityQueryOptions.IncludeAll,
        });
        
        __query_666345371_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.TheMonsterGeneratorActiveBuff>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.MonsterGeneratorBindingInitialized>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeSpawnTag | EntityQueryOptions.IncludeAll,
        });
        
        __query_666345371_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.AiPointOfInterest>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeSpawnTag | EntityQueryOptions.IncludeAll,
        });
        
    }
    

}
