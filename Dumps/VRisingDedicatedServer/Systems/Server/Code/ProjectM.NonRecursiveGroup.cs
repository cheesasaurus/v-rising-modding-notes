using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.RecursiveGroup), OrderLast = true)]
public class NonRecursiveGroup : ComponentSystemGroup
{

}
