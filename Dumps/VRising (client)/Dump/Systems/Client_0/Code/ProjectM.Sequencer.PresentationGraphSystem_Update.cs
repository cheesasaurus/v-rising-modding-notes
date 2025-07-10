using Unity.Entities;

namespace ProjectM.Sequencer;


[UpdateInGroup(typeof(ProjectM.Sequencer.SequencerPresentationGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct PresentationGraphSystem_Update : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_1870654329_0;
    EntityQuery __query_1870654329_1;
    EntityQuery __query_1870654329_2;
    EntityQuery __query_1870654329_3;
    EntityQuery __query_1870654329_4;
    EntityQuery __query_1870654329_5;
    EntityQuery __query_1870654329_6;
    EntityQuery __query_1870654329_7;
    
    // unmanaged system, skipped generating example queries

}
