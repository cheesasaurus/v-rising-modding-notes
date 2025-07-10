using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.FinalizeGroup_Server))]
[RequireMatchingQueriesForUpdateAttribute]
public struct DisableWhenNoPlayersInRangeSystem_Server : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1329487913_0;
    EntityQuery __query_1329487913_1;
    EntityQuery __query_1329487913_2;
    
    // unmanaged system, skipped generating example queries

}
