using Unity.Entities;

namespace Rukhanka;


[UpdateInGroup(typeof(Rukhanka.RukhankaAnimationSystemGroup))]
[UpdateAfter(typeof(Rukhanka.AnimationProcessSystem))]
public class RukhankaAnimationInjectionSystemGroup : ComponentSystemGroup
{

}
