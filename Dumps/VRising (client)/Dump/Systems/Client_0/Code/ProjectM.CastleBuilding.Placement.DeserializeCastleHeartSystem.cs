using Unity.Entities;

namespace ProjectM.CastleBuilding.Placement;


[UpdateInGroup(typeof(ProjectM.ReactToDeserializeGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct DeserializeCastleHeartSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _CastleHeartChangedQuery;
    EntityQuery __query_669087197_0;
    EntityQuery __query_669087197_1;
    
    // unmanaged system, skipped generating example queries

}
