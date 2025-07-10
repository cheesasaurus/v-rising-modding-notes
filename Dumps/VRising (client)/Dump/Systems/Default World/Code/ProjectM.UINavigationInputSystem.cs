using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(InitializationSystemGroup), OrderLast = true)]
public class UINavigationInputSystem : SystemBase, ProjectM.IInputContext
{

}
