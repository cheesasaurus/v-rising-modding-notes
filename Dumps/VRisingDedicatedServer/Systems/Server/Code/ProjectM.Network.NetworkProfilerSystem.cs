using Unity.Entities;

namespace ProjectM.Network;


[UpdateInGroup(typeof(ProjectM.SerializeGroup))]
[UpdateAfter(typeof(ProjectM.Network.MakePacketSystem))]
public class NetworkProfilerSystem : SystemBase
{

}
