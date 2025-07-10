using Unity.Entities;

namespace ProjectM.Gameplay.WarEvents;


[UpdateInGroup(typeof(ProjectM.UpdateGroup), OrderLast = true)]
public class WarEventUpdateGroup : ComponentSystemGroup
{

}
