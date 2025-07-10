using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[UpdateAfter(typeof(ProjectM.GetHybridDataGroup))]
public class SetHybridDataGroup : ComponentSystemGroup
{

}
