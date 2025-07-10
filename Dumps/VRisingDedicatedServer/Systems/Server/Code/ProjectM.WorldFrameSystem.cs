using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(InitializationSystemGroup), OrderFirst = true)]
[RequireMatchingQueriesForUpdateAttribute]
public class WorldFrameSystem : SystemBase, ProjectM.IPersistentSystemSerializer
{

}
