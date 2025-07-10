using Unity.Entities;

namespace ProjectM.CastleBuilding.Rebuilding;


[UpdateInGroup(typeof(ProjectM.ReactToPersistenceLoadedGroup))]
[UpdateAfter(typeof(ProjectM.Network.SetupNetworkIdSystem_OnPersistenceLoad))]
[RequireMatchingQueriesForUpdateAttribute]
public struct CastleRebuildRegistryPersistenceSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _PhasedCastleHeartLoadedQuery;
    EntityQuery __query_882754694_0;
    EntityQuery __query_882754694_1;
    EntityQuery __query_882754694_2;
    EntityQuery __query_882754694_3;
    EntityQuery __query_882754694_4;
    EntityQuery __query_882754694_5;
    EntityQuery __query_882754694_6;
    
    // unmanaged system, skipped generating example queries

}
