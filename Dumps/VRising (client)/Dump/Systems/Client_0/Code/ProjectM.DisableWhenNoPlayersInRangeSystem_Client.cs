using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.FinalizeGroup_Client))]
[RequireMatchingQueriesForUpdateAttribute]
public struct DisableWhenNoPlayersInRangeSystem_Client : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1329487941_0;
    EntityQuery __query_1329487941_1;
    EntityQuery __query_1329487941_2;
    
    // unmanaged system, skipped generating example queries

}
