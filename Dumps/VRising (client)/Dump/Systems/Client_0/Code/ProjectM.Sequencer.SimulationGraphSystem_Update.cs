using Unity.Entities;

namespace ProjectM.Sequencer;


[UpdateInGroup(typeof(ProjectM.Sequencer.SequencerUpdateGroup))]
[UpdateBefore(typeof(ProjectM.Sequencer.UpdatePostGraphSystem))]
[UpdateAfter(typeof(ProjectM.Sequencer.UpdateFlowEventsSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public struct SimulationGraphSystem_Update : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_1870654268_0;
    EntityQuery __query_1870654268_1;
    EntityQuery __query_1870654268_2;
    EntityQuery __query_1870654268_3;
    EntityQuery __query_1870654268_4;
    EntityQuery __query_1870654268_5;
    EntityQuery __query_1870654268_6;
    EntityQuery __query_1870654268_7;
    
    // unmanaged system, skipped generating example queries

}
