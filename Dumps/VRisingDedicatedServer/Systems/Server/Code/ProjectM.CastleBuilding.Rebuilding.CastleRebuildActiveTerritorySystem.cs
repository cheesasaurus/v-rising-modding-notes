using Unity.Entities;

namespace ProjectM.CastleBuilding.Rebuilding;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct CastleRebuildActiveTerritorySystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_670161660_0;
    EntityQuery __query_670161660_1;
    EntityQuery __query_670161660_2;
    EntityQuery __query_670161660_3;
    EntityQuery __query_670161660_4;
    
    // unmanaged system, skipped generating example queries

}
