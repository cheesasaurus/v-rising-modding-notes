using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.MoveGroup))]
[UpdateAfter(typeof(ProjectM.MoveWithCurveSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public struct RotateTowardsTargetDirection_Server : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1651954915_0;
    EntityQuery __query_1651954915_1;
    
    // unmanaged system, skipped generating example queries

}
