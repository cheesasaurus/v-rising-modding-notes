using Unity.Entities;

namespace ProjectM.CastleBuilding;


[UpdateInGroup(typeof(ProjectM.ReactToTileBoundsGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct CastleFallingSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _RemovedFloorsQuery;
    EntityQuery _AddedFloorsQuery;
    EntityQuery __query_1216833508_0;
    EntityQuery __query_1216833508_1;
    EntityQuery __query_1216833508_2;
    
    // unmanaged system, skipped generating example queries

}
