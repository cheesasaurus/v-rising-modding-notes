using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.StartSimulationGroup))]
public class DestroyEntitiesBarrier_Server : ProjectM.StunlockEntityCommandBufferSystem
{

}
