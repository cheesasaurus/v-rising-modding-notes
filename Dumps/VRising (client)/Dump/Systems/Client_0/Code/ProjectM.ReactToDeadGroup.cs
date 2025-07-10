using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.RecursiveGroup))]
[UpdateAfter(typeof(ProjectM.StatChangeGroup))]
public class ReactToDeadGroup : ComponentSystemGroup
{

}
