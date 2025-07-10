using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.AiGroup), OrderLast = true)]
[UpdateAfter(typeof(ProjectM.AiSubGroup1))]
public class AiSubGroup2 : ComponentSystemGroup
{

}
