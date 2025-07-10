using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.DeserializeGroup))]
[UpdateAfter(typeof(ProjectM.DeserializeComponentsGroup))]
public class ReactToDeserializeGroup : ComponentSystemGroup
{

}
