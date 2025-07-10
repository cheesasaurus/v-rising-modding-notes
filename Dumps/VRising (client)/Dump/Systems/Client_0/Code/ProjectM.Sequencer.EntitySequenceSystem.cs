using Unity.Entities;

namespace ProjectM.Sequencer;


[UpdateInGroup(typeof(ProjectM.Sequencer.BeforeSequencerUpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct EntitySequenceSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_97767581_0;
    
    // unmanaged system, skipped generating example queries

}
