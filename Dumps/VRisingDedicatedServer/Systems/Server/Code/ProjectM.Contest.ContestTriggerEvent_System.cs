using Unity.Entities;

namespace ProjectM.Contest;


[UpdateInGroup(typeof(ProjectM.ReactToContestEventGroup), OrderFirst = true)]
[RequireMatchingQueriesForUpdateAttribute]
public struct ContestTriggerEvent_System : ISystem, ISystemCompilerGenerated
{
    EntityQuery _DefeatedParticipantEventQuery;
    EntityQuery _ContestCancelledEventQuery;
    EntityQuery _ContestDrawEventQuery;
    EntityQuery __query_801697112_0;
    EntityQuery __query_801697112_1;
    EntityQuery __query_801697112_2;
    EntityQuery __query_801697112_3;
    
    // unmanaged system, skipped generating example queries

}
