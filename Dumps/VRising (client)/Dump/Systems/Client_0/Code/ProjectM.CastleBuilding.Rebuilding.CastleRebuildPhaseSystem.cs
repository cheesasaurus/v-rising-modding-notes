using Unity.Entities;

namespace ProjectM.CastleBuilding.Rebuilding;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct CastleRebuildPhaseSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _PhaseQuery;
    EntityQuery __query_934265926_0;
    EntityQuery __query_934265926_1;
    
    // unmanaged system, skipped generating example queries

}
