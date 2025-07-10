using Unity.Entities;

namespace ProjectM.Sequencer;


[UpdateInGroup(typeof(ProjectM.Sequencer.SequencerUpdateGroup))]
[UpdateBefore(typeof(ProjectM.Sequencer.UpdatePostGraphSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public struct UpdateFlowEventsSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_1487103518_0;
    EntityQuery __query_1487103518_1;
    EntityQuery __query_1487103518_2;
    EntityQuery __query_1487103518_3;
    EntityQuery __query_1487103518_4;
    EntityQuery __query_1487103518_5;
    
    // unmanaged system, skipped generating example queries

}
