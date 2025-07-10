using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.RecursiveGroup))]
public class DestroyBarrier : ProjectM.StunlockEntityCommandBufferSystem
{

}
