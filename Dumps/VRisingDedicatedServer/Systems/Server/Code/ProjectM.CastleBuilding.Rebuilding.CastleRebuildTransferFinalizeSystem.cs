using Unity.Entities;

namespace ProjectM.CastleBuilding.Rebuilding;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct CastleRebuildTransferFinalizeSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _TransferFinalizedQuery;
    EntityQuery __query_1917160944_0;
    EntityQuery __query_1917160944_1;
    
    // unmanaged system, skipped generating example queries

}
