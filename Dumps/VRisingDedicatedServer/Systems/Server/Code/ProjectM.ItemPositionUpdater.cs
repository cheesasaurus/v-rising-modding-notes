using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.LateUpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct ItemPositionUpdater : ISystem, ISystemCompilerGenerated
{
    EntityQuery _MoveExternalInventoryJobQuery;
    
    // unmanaged system, skipped generating example queries

}
