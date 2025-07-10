using Unity.Entities;

namespace ProjectM.Gameplay.Clan;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct ClanSystem_InviteTimeout_Server : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_369389856_0;
    
    // unmanaged system, skipped generating example queries

}
