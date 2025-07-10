using Unity.Entities;

namespace ProjectM.CastleBuilding.Placement;


[UpdateInGroup(typeof(ProjectM.ReactToDestroyTagGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct DestroyCastleHeartSystem_Client : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_669087269_0;
    
    // unmanaged system, skipped generating example queries

}
