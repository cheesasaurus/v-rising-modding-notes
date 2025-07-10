using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(SimulationSystemGroup))]
[UpdateBefore(typeof(EndSimulationEntityCommandBufferSystem))]
[UpdateAfter(typeof(ProjectM.SerializeGroup))]
public class FinalizeGroup_Client : ComponentSystemGroup
{

}
