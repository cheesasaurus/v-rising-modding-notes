using Unity.Entities;

namespace ProjectM.Contest;


[UpdateInGroup(typeof(ProjectM.AfterRecursiveSpawnDestroyGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct ContestTeamEventListener_System : ISystem, ISystemCompilerGenerated
{
    EntityQuery _TeamParticipantEventQuery;
    EntityQuery __query_801697289_0;
    
    // unmanaged system, skipped generating example queries

}
