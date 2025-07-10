using Unity.Entities;

namespace ProjectM.Network;


[UpdateInGroup(typeof(ProjectM.DeserializeGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct DeserializeUserInputSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _IncomingUserInputsQuery;
    EntityQuery __query_1984122521_0;
    EntityQuery __query_1984122521_1;
    EntityQuery __query_1984122521_2;
    EntityQuery __query_1984122521_3;
    
    // unmanaged system, skipped generating example queries

}
