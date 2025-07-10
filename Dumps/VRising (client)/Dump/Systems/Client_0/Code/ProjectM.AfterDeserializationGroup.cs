using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.DeserializeGroup))]
[UpdateAfter(typeof(ProjectM.EndDeserializeBarrier))]
public class AfterDeserializationGroup : ComponentSystemGroup
{

}
