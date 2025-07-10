using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(SimulationSystemGroup))]
[UpdateAfter(typeof(ProjectM.EarlyUpdateGroup))]
public class UpdateGroup : ComponentSystemGroup
{

}
