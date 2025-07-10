using Unity.Entities;

namespace ProjectM.CastleBuilding;


[UpdateInGroup(typeof(ProjectM.ReactToTileBoundsGroup))]
[UpdateAfter(typeof(ProjectM.CastleBuilding.CastleFloorAndWallsUpdateSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public struct CastleBuildingSearchRoomSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _AddedWallsQuery;
    EntityQuery _MovedWallsQuery;
    EntityQuery _RemovedWallsQuery;
    EntityQuery _AddedFloorsQuery;
    EntityQuery _MovedFloorsQuery;
    EntityQuery _RemovedFloorsQuery;
    EntityQuery __query_783147806_0;
    EntityQuery __query_783147806_1;
    EntityQuery __query_783147806_2;
    EntityQuery __query_783147806_3;
    EntityQuery __query_783147806_4;
    EntityQuery __query_783147806_5;
    EntityQuery __query_783147806_6;
    EntityQuery __query_783147806_7;
    EntityQuery __query_783147806_8;
    
    // unmanaged system, skipped generating example queries

}
