using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.DestroyTagGroup), OrderLast = true)]
[RequireMatchingQueriesForUpdateAttribute]
public struct ProcessDestroyEventSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _EventQuery;
    EntityQuery __query_917392546_0;
    EntityQuery __query_917392546_1;
    EntityQuery __query_917392546_2;
    EntityQuery __query_917392546_3;
    
    // unmanaged system, skipped generating example queries

}
