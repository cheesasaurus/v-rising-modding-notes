using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(InitializationSystemGroup), OrderFirst = true)]
public class ECBSyncPointManager : SystemBase
{

}
