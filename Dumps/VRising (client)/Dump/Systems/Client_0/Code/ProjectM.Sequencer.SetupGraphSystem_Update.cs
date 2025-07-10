using Unity.Entities;

namespace ProjectM.Sequencer;


[UpdateInGroup(typeof(ProjectM.Sequencer.SequencerUpdateGroup))]
[UpdateBefore(typeof(ProjectM.Sequencer.UpdateFlowEventsSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public struct SetupGraphSystem_Update : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_968932273_0;
    EntityQuery __query_968932273_1;
    EntityQuery __query_968932273_2;
    EntityQuery __query_968932273_3;
    EntityQuery __query_968932273_4;
    EntityQuery __query_968932273_5;
    EntityQuery __query_968932273_6;
    EntityQuery __query_968932273_7;
    
    // unmanaged system, skipped generating example queries

}
