using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[UpdateAfter(typeof(ProjectM.InputGroup))]
public class MoveGroup : ComponentSystemGroup
{

}
