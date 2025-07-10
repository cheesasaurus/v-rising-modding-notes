using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(SimulationSystemGroup))]
[UpdateAfter(typeof(ProjectM.UpdateGroup))]
public class LateUpdateGroup : ComponentSystemGroup
{

}
