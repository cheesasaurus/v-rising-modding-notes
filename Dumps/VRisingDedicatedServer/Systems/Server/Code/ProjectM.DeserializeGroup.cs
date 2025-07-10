using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.StartSimulationGroup))]
[UpdateAfter(typeof(ProjectM.StartSimulationGroupBarrier))]
public class DeserializeGroup : ComponentSystemGroup
{

}
