using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.StartSimulationGroup))]
[UpdateBefore(typeof(ProjectM.StartSimulationGroupBarrier))]
[UpdateAfter(typeof(ProjectM.DestroyEntitiesBarrier_Server))]
public class DestroyGroup_Server : ComponentSystemGroup
{

}
