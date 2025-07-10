using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UIGroup), OrderFirst = true)]
public class ScheduleBeforeUIGroup : ComponentSystemGroup
{

}
