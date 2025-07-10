using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup), OrderLast = true)]
public class ReactToInventoryChangedEventGroup : ComponentSystemGroup
{

}
