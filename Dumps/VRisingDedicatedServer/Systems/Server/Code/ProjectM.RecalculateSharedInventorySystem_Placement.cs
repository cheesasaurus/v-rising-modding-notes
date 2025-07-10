using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup), OrderLast = true)]
[RequireMatchingQueriesForUpdateAttribute]
public struct RecalculateSharedInventorySystem_Placement : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_614111063_0;
    EntityQuery __query_614111063_1;
    EntityQuery __query_614111063_2;
    
    // unmanaged system, skipped generating example queries

}
