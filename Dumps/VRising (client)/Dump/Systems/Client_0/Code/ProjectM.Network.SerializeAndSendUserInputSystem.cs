using Unity.Entities;

namespace ProjectM.Network;


[UpdateInGroup(typeof(ProjectM.SerializeGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct SerializeAndSendUserInputSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _SerializeQuery;
    EntityQuery __query_1984122257_0;
    EntityQuery __query_1984122257_1;
    EntityQuery __query_1984122257_2;
    EntityQuery __query_1984122257_3;
    
    // unmanaged system, skipped generating example queries

}
