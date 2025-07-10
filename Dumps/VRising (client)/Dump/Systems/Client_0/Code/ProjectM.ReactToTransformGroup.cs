using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(SimulationSystemGroup))]
[UpdateAfter(typeof(ProjectM.BeforeTransformSystemGroup))]
public class ReactToTransformGroup : ComponentSystemGroup
{

}
