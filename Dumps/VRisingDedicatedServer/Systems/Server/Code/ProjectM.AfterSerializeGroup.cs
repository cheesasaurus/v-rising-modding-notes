using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.SerializeGroup), OrderLast = true)]
public class AfterSerializeGroup : ComponentSystemGroup
{

}
