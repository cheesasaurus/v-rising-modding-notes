using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(SimulationSystemGroup), OrderFirst = true)]
[UpdateBefore(typeof(ProjectM.StartSimulationGroup))]
public class BeforeStartSimulationGroupBarrier : ProjectM.StunlockEntityCommandBufferSystem
{

}
