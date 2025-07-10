using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.StartSimulationGroup))]
[UpdateBefore(typeof(ProjectM.DeserializeGroup))]
[UpdateAfter(typeof(ProjectM.StartSimulationGroupBarrier))]
public class AfterDestroyGroup_Server : ComponentSystemGroup
{

}
