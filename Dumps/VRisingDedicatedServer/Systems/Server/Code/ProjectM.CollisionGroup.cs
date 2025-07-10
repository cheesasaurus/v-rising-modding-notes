using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(SimulationSystemGroup))]
[UpdateBefore(typeof(ProjectM.SerializeGroup))]
[UpdateAfter(typeof(ProjectM.SerializeBarrier))]
public class CollisionGroup : ComponentSystemGroup
{

}
