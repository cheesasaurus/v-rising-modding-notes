using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(ProjectM.BuildModeGroup), OrderLast = true)]
[RequireMatchingQueriesForUpdateAttribute]
public struct BuildModeCleanupSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_712255855_0;
    
    // unmanaged system, skipped generating example queries

}
