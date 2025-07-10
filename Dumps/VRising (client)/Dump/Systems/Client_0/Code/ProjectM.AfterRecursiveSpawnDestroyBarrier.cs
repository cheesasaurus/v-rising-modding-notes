using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.AfterRecursiveSpawnDestroyGroup))]
public class AfterRecursiveSpawnDestroyBarrier : ProjectM.StunlockEntityCommandBufferSystem
{

}
