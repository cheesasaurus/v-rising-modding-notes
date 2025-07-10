using Unity.Entities;

namespace ProjectM.UI;


[UpdateInGroup(typeof(InitializationSystemGroup), OrderLast = true)]
public class GenericPopupSystem : SystemBase, ProjectM.IInputContext
{

}
