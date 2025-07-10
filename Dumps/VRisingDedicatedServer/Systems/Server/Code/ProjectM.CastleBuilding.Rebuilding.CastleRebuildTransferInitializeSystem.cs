using Unity.Entities;

namespace ProjectM.CastleBuilding.Rebuilding;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[UpdateBefore(typeof(ProjectM.CastleBuilding.Rebuilding.CastleRebuildTransferSystem))]
[UpdateAfter(typeof(ProjectM.CastleBuilding.Rebuilding.CastleRebuildRegistryServerEventSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public struct CastleRebuildTransferInitializeSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _TransferInitializeEventQuery;
    EntityQuery __query_1917160607_0;
    EntityQuery __query_1917160607_1;
    EntityQuery __query_1917160607_2;
    EntityQuery __query_1917160607_3;
    EntityQuery __query_1917160607_4;
    
    // unmanaged system, skipped generating example queries

}
