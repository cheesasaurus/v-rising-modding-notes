using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(SimulationSystemGroup))]
[UpdateAfter(typeof(ProjectM.LateUpdateGroup))]
public class PostUpdateBarrier : ProjectM.StunlockEntityCommandBufferSystem
{

}
