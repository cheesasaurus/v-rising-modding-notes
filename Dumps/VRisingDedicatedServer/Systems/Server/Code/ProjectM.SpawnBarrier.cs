using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.RecursiveGroup))]
[UpdateAfter(typeof(ProjectM.BeforeSpawnGroup))]
public class SpawnBarrier : ProjectM.StunlockEntityCommandBufferSystem
{

}
