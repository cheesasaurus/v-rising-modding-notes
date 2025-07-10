using Unity.Entities;

namespace ProjectM.CastleBuilding;


[UpdateInGroup(typeof(ProjectM.ReactToTilePositionGroup))]
[UpdateBefore(typeof(ProjectM.CastleBuilding.TileModelEventsBarrier))]
[RequireMatchingQueriesForUpdateAttribute]
public struct CastlePillarEvents : ISystem, ISystemCompilerGenerated
{

}
