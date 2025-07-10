using Unity.Entities;

namespace ProjectM.Contest;


[UpdateInGroup(typeof(ProjectM.UpdateGroup), OrderLast = true)]
[RequireMatchingQueriesForUpdateAttribute]
public struct ContestStatusSCTSystem : ISystem, ISystemCompilerGenerated, ISystemStartStop
{
    EntityQuery __query_647479060_0;
    EntityQuery __query_647479060_1;
    EntityQuery __query_647479060_2;
    EntityQuery __query_647479060_3;
    EntityQuery __query_647479060_4;
    
    // unmanaged system, skipped generating example queries

}
