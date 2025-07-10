using Unity.Entities;

namespace ProjectM.Gameplay.Clan;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct ClanSystem_GetEditInfo_Client : ISystem, ISystemCompilerGenerated
{
    EntityQuery _LastUpdatedByQuery;
    EntityQuery __query_369390202_0;
    EntityQuery __query_369390202_1;
    
    // unmanaged system, skipped generating example queries

}
