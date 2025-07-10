using Unity.Entities;

namespace ProjectM.CastleBuilding;


[UpdateInGroup(typeof(ProjectM.ReactToTilePositionGroup))]
[UpdateAfter(typeof(ProjectM.CastleBuilding.TileModelEventsBarrier))]
[RequireMatchingQueriesForUpdateAttribute]
public class CastleBlockSystem : SystemBase
{

}
