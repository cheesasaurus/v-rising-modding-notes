using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.NoStructuralChangesGroup))]
[UpdateAfter(typeof(ProjectM.CrowdednessSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public struct CrowdednessCleanupOnDisconnectSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _CrowdednessQuery;
    EntityQuery _EventQuery;
    EntityQuery __query_2048942349_0;
    EntityQuery __query_2048942349_1;
    
    // unmanaged system, skipped generating example queries

}
