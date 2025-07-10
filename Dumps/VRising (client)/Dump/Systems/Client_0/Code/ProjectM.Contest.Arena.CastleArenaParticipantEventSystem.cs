using Unity.Entities;

namespace ProjectM.Contest.Arena;


[UpdateInGroup(typeof(ProjectM.ReactToContestEventGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct CastleArenaParticipantEventSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _ParticipantEventQuery;
    EntityQuery __query_2009269760_0;
    EntityQuery __query_2009269760_1;
    EntityQuery __query_2009269760_2;
    
    // unmanaged system, skipped generating example queries

}
