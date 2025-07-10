using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(SimulationSystemGroup))]
[UpdateAfter(typeof(ProjectM.ReactToTransformGroup))]
public class BeforeSerializeBarrierGroup : ComponentSystemGroup
{

}
