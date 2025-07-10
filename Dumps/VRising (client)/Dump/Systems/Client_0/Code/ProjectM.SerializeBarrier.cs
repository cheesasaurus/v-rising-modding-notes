using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(SimulationSystemGroup))]
[UpdateAfter(typeof(ProjectM.BeforeSerializeBarrierGroup))]
public class SerializeBarrier : ProjectM.StunlockEntityCommandBufferSystem
{

}
