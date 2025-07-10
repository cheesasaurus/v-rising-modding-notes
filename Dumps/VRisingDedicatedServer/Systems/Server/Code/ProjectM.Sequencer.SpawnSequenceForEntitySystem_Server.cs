using Unity.Entities;

namespace ProjectM.Sequencer;


[UpdateInGroup(typeof(ProjectM.ReactToSpawnGroup))]
[UpdateAfter(typeof(ProjectM.SetupInitialStatesGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class SpawnSequenceForEntitySystem_Server : SystemBase
{
    EntityQuery __query_998741700_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_998741700_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<ProjectM.Sequencer.SpawnSequenceForEntity>(),
                ComponentType.ReadOnly<Unity.Entities.SpawnTag>(),
            },
            Options = EntityQueryOptions.IncludeDisabled | EntityQueryOptions.IncludeAll,
        });
        
    }
    

}
