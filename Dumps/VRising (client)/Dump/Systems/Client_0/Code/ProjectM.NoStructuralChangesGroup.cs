using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ScheduleParentGroup))]
[UpdateAfter(typeof(ProjectM.ScheduleGroup))]
public class NoStructuralChangesGroup : ComponentSystemGroup
{

}
