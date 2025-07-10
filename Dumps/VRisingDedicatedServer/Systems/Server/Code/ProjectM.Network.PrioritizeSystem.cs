using Unity.Entities;

namespace ProjectM.Network;


[UpdateInGroup(typeof(ProjectM.SerializeGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct PrioritizeSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _AlwaysNetworkEntityQuery;
    EntityQuery _CloseToUserQuery;
    EntityQuery _CloseToUserStaticQuery;
    EntityQuery _AttachedQuery;
    EntityQuery __query_1662520936_0;
    EntityQuery __query_1662520936_1;
    EntityQuery __query_1662520936_2;
    EntityQuery __query_1662520936_3;
    EntityQuery __query_1662520936_4;
    EntityQuery __query_1662520936_5;
    
    // unmanaged system, skipped generating example queries

}
