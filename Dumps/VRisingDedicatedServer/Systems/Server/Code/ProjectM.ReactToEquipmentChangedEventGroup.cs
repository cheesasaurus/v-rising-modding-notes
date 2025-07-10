using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup), OrderLast = true)]
[UpdateBefore(typeof(ProjectM.ReactToInventoryChangedEventGroup))]
public class ReactToEquipmentChangedEventGroup : ComponentSystemGroup
{

}
