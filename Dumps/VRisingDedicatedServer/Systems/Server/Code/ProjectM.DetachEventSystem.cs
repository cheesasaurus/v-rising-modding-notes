using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup), OrderLast = true)]
[RequireMatchingQueriesForUpdateAttribute]
public struct DetachEventSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _DetachEventQuery;
    EntityQuery _RemoveEventQuery;
    EntityQuery __query_1706119416_0;
    EntityQuery __query_1706119416_1;
    EntityQuery __query_1706119416_2;
    EntityQuery __query_1706119416_3;
    EntityQuery __query_1706119416_4;
    EntityQuery __query_1706119416_5;
    
    // unmanaged system, skipped generating example queries

}
