using Unity.Entities;

namespace ProjectM.Contest.Arena;


[UpdateInGroup(typeof(ProjectM.DeserializeGroup))]
[UpdateAfter(typeof(ProjectM.Contest.Arena.ArenaSyncSetupInstanceFromParent_Client))]
[RequireMatchingQueriesForUpdateAttribute]
public struct ArenaSyncInstanceToParent_Client : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_2082047581_0;
    
    // unmanaged system, skipped generating example queries

}
