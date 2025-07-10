using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.StartSimulationGroup))]
public class StartSimulationGroupBarrier : ProjectM.StunlockEntityCommandBufferSystem
{

}
