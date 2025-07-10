using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.AfterRecursiveSpawnDestroyGroup))]
public struct CreatedDelayedDestroyEventSystem : ISystem
{

}
