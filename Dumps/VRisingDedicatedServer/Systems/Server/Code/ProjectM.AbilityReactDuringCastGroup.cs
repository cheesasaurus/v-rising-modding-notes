using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.AbilityGroup), OrderLast = true)]
[UpdateBefore(typeof(ProjectM.AbilityReactToCastFinishGroup))]
[UpdateAfter(typeof(ProjectM.AbilityReactToCastStartGroup))]
public class AbilityReactDuringCastGroup : ComponentSystemGroup
{

}
