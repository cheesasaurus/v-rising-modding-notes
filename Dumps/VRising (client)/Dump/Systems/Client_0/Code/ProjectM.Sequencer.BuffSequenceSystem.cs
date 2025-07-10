using Unity.Entities;

namespace ProjectM.Sequencer;


[UpdateInGroup(typeof(ProjectM.Sequencer.BeforeSequencerUpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct BuffSequenceSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_313887960_0;
    
    // unmanaged system, skipped generating example queries

}
