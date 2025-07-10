using Unity.Entities;

namespace ProjectM.Sequencer.Debugging;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[UpdateAfter(typeof(ProjectM.Sequencer.SequencerPresentationGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public class SequenceDebuggerSystem : SystemBase
{
    EntityQuery __query_562793277_0;
    EntityQuery __query_562793277_1;
    
    public void Example_InitEntityQueries(EntityManager entityManager)
    {
        __query_562793277_0 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadOnly<Stunlock.Sequencer.SequenceAsset>(),
                ComponentType.ReadOnly<Stunlock.Sequencer.SequenceInput>(),
            },
            None = new ComponentType[] {
                ComponentType.ReadOnly<ProjectM.Sequencer.Debugging.SequencerDebugHistoryInfo>(),
            },
        });
        
        __query_562793277_1 = entityManager.CreateEntityQuery(new EntityQueryDesc()
        {
            All = new ComponentType[] {
                ComponentType.ReadWrite<Stunlock.Sequencer.SequenceInstance>(),
                ComponentType.ReadWrite<Stunlock.Sequencer.SequenceAsset>(),
                ComponentType.ReadWrite<ProjectM.Sequencer.Debugging.SequencerDebugHistoryInfo>(),
                ComponentType.ReadWrite<Stunlock.Sequencer.EventStateElement>(),
                ComponentType.ReadWrite<ProjectM.Sequencer.Debugging.SequencerStateHistory>(),
                ComponentType.ReadWrite<ProjectM.Sequencer.Debugging.SequencerBlackboardHistory>(),
            },
        });
        
    }
    

}
