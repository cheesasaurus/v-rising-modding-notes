using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct SyncAimDataLerp : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_335313501_0;
    
    // unmanaged system, skipped generating example queries

}
