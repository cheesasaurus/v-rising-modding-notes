using Unity.Entities;

namespace ProjectM.Contest.Duel;


[UpdateInGroup(typeof(ProjectM.ReactToContestEventGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct DuelEventListenerSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _DuelFinishedEventQuery;
    EntityQuery _DuelCancelledEventQuery;
    EntityQuery _ParticipantDefeatedEventQuery;
    EntityQuery __query_255198667_0;
    EntityQuery __query_255198667_1;
    EntityQuery __query_255198667_2;
    EntityQuery __query_255198667_3;
    EntityQuery __query_255198667_4;
    EntityQuery __query_255198667_5;
    
    // unmanaged system, skipped generating example queries

}
