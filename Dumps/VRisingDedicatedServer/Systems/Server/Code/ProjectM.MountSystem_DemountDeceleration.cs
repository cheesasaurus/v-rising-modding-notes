using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.SetInputGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct MountSystem_DemountDeceleration : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_1228665761_0;
    EntityQuery __query_1228665761_1;
    
    // unmanaged system, skipped generating example queries

}
