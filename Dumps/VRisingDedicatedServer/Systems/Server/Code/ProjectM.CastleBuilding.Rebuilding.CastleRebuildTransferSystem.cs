using Unity.Entities;

namespace ProjectM.CastleBuilding.Rebuilding;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct CastleRebuildTransferSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _TransferOperationQuery;
    EntityQuery __query_1917160838_0;
    
    // unmanaged system, skipped generating example queries

}
