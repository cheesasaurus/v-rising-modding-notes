using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.LateUpdateGroup))]
[UpdateBefore(typeof(ProjectM.TimeScaleSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public struct TimeScaleEventSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _TimeScaleEventQuery;
    EntityQuery __query_632282719_0;
    EntityQuery __query_632282719_1;
    
    // unmanaged system, skipped generating example queries

}
