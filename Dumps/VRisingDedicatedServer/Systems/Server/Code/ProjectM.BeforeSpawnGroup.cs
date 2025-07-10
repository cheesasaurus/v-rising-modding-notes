using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.RecursiveGroup))]
[UpdateAfter(typeof(ProjectM.DestroyGroup))]
public class BeforeSpawnGroup : ComponentSystemGroup
{

}
