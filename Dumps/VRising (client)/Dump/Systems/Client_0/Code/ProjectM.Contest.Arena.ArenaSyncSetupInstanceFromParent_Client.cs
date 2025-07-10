using Unity.Entities;

namespace ProjectM.Contest.Arena;


[UpdateInGroup(typeof(ProjectM.DeserializeGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct ArenaSyncSetupInstanceFromParent_Client : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_2082047553_0;
    
    // unmanaged system, skipped generating example queries

}
