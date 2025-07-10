using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(SimulationSystemGroup))]
[UpdateAfter(typeof(ProjectM.AfterRecursiveSpawnDestroyGroup))]
public class BeforeTransformSystemGroup : ComponentSystemGroup
{

}
