using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(SimulationSystemGroup))]
[UpdateAfter(typeof(ProjectM.StartSimulationGroup))]
public class EarlyUpdateGroup : ComponentSystemGroup
{

}
