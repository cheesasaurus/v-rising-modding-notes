using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.MoveGroup), OrderFirst = true)]
public class AbilityMoveGroup : ComponentSystemGroup
{

}
