using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(SimulationSystemGroup))]
[UpdateAfter(typeof(ProjectM.SerializeBarrier))]
public class SerializeGroup : ComponentSystemGroup
{

}
