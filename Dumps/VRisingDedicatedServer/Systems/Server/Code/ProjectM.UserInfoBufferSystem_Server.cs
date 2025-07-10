using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct UserInfoBufferSystem_Server : ISystem, ISystemCompilerGenerated
{
    EntityQuery _UserConnectionChangedQuery;
    EntityQuery _UserInfoRequestQuery;
    EntityQuery __query_1133664022_0;
    EntityQuery __query_1133664022_1;
    EntityQuery __query_1133664022_2;
    EntityQuery __query_1133664022_3;
    EntityQuery __query_1133664022_4;
    
    // unmanaged system, skipped generating example queries

}
