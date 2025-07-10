using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(SimulationSystemGroup))]
[UpdateBefore(typeof(ProjectM.ReactToTransformGroup))]
[UpdateAfter(typeof(ProjectM.BeforeTransformSystemGroup))]
public class TransformGroup : ComponentSystemGroup
{

}
