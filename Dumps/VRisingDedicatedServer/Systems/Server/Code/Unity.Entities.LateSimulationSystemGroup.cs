
namespace Unity.Entities;


[UpdateInGroup(typeof(SimulationSystemGroup), OrderLast = true)]
[UpdateBefore(typeof(EndSimulationEntityCommandBufferSystem))]
public class LateSimulationSystemGroup : TimeableComponentSystemGroup
{

}
