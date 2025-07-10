using Unity.Entities;

namespace Animation;


[UpdateInGroup(typeof(Rukhanka.RukhankaAnimationSystemGroup))]
[UpdateBefore(typeof(Rukhanka.FillAnimationsFromControllerSystem))]
[UpdateAfter(typeof(Rukhanka.AnimatorControllerSystem<Rukhanka.AnimatorControllerQuery>))]
public struct AnimatorStateBehavioursSystem : ISystem, ISystemCompilerGenerated
{

}
