using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.AbilityGroup), OrderFirst = true)]
[UpdateBefore(typeof(ProjectM.AbilityReactToCastStartGroup))]
public class AbilityInitializeGroup : ComponentSystemGroup
{

}
