using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.LateUpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct TakeDamageInSunSystem_Server : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1202092200_0;
    EntityQuery __query_1202092200_1;
    EntityQuery __query_1202092200_2;
    EntityQuery __query_1202092200_3;
    
    // unmanaged system, skipped generating example queries

}
