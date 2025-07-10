using Unity.Entities;

namespace ProjectM.Sequencer;


[UpdateInGroup(typeof(ProjectM.Sequencer.SequencerUpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct UpdatePostGraphSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_255242060_0;
    EntityQuery __query_255242060_1;
    EntityQuery __query_255242060_2;
    EntityQuery __query_255242060_3;
    
    // unmanaged system, skipped generating example queries

}
