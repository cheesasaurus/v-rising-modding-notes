using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.DeserializeGroup))]
[UpdateAfter(typeof(ProjectM.ReactToDeserializeGroup))]
public class EndDeserializeBarrier : ProjectM.StunlockEntityCommandBufferSystem
{

}
