using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.AbilityGroup), OrderLast = true)]
[UpdateBefore(typeof(ProjectM.AbilityReactDuringCastGroup))]
[UpdateAfter(typeof(ProjectM.AbilityInitializeGroup))]
public class AbilityReactToCastStartGroup : ComponentSystemGroup
{

}
