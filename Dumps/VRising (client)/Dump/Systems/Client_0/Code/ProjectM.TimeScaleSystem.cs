using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.LateUpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct TimeScaleSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_632282757_0;
    EntityQuery __query_632282757_1;
    EntityQuery __query_632282757_2;
    EntityQuery __query_632282757_3;
    
    // unmanaged system, skipped generating example queries

}
