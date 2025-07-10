using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(SimulationSystemGroup))]
[UpdateAfter(typeof(ProjectM.RecursiveGroup))]
public class AfterRecursiveSpawnDestroyGroup : ComponentSystemGroup
{

}
