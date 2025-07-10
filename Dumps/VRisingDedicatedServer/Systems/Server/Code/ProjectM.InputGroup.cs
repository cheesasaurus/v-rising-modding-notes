using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[UpdateAfter(typeof(ProjectM.AiGroup))]
public class InputGroup : ComponentSystemGroup
{

}
