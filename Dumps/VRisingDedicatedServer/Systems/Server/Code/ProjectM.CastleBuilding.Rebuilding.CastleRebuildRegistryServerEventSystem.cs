using Unity.Entities;

namespace ProjectM.CastleBuilding.Rebuilding;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct CastleRebuildRegistryServerEventSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _ConnectEvents;
    EntityQuery _DisconnectEvents;
    EntityQuery _TransferEvents;
    EntityQuery _AllEvents;
    EntityQuery __query_1194927125_0;
    EntityQuery __query_1194927125_1;
    EntityQuery __query_1194927125_2;
    EntityQuery __query_1194927125_3;
    EntityQuery __query_1194927125_4;
    EntityQuery __query_1194927125_5;
    EntityQuery __query_1194927125_6;
    EntityQuery __query_1194927125_7;
    EntityQuery __query_1194927125_8;
    
    // unmanaged system, skipped generating example queries

}
