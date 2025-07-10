using Unity.Entities;

namespace ProjectM.CastleBuilding;


[UpdateInGroup(typeof(ProjectM.ReactToTilePositionGroup))]
public class TileModelEventsBarrier : ProjectM.StunlockEntityCommandBufferSystem
{

}
