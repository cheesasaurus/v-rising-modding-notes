using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.AbilityGroup), OrderLast = true)]
[UpdateAfter(typeof(ProjectM.AbilityReactDuringCastGroup))]
public class AbilityReactToCastFinishGroup : ComponentSystemGroup
{

}
