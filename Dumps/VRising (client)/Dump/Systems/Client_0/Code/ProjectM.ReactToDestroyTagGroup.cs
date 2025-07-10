using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.DestroyGroup))]
[UpdateAfter(typeof(ProjectM.DestroyTagGroup))]
public class ReactToDestroyTagGroup : ComponentSystemGroup
{

}
