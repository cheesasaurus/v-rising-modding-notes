using Unity.Entities;

namespace ProjectM.Sequencer;


[UpdateInGroup(typeof(ProjectM.ReactToDeserializeGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class CreateSequenceSystem_Deserialize : ProjectM.Sequencer.CreateSequenceSystemBase
{
    EntityQuery _Query;
    EntityQuery __query_1619751317_0;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        _Query = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<Stunlock.Sequencer.SequenceAsset>(),
                ComponentType.ReadWrite<Stunlock.Sequencer.CreateSequence>(),
            },
            Options = EntityQueryOptions.IncludeSpawnTag | EntityQueryOptions.IncludeAll,
        });
        
        __query_1619751317_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Sequencer.SequenceInput>(),
                ComponentType.ReadWrite<Stunlock.Sequencer.DefaultBlackboardValueElement>(),
                ComponentType.ReadWrite<Stunlock.Sequencer.BlackboardElement>(),
                ComponentType.ReadOnly<Stunlock.Sequencer.CreateSequence>(),
            },
            Options = EntityQueryOptions.IncludeSpawnTag | EntityQueryOptions.IncludeAll,
        });
        
    }
    

}
