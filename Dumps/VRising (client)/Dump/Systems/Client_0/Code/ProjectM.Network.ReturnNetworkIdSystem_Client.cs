using Unity.Entities;

namespace ProjectM.Network;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct ReturnNetworkIdSystem_Client : ISystem, ISystemCompilerGenerated
{
    EntityQuery _MainQuery;
    EntityQuery __query_309821609_0;
    EntityQuery __query_309821609_1;
    
    // unmanaged system, skipped generating example queries

}
