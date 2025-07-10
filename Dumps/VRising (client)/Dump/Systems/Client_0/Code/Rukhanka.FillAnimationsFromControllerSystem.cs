using Unity.Entities;

namespace Rukhanka;


[UpdateInGroup(typeof(Rukhanka.RukhankaAnimationSystemGroup))]
[UpdateAfter(typeof(Rukhanka.AnimatorControllerSystem<Rukhanka.AnimatorControllerQuery>))]
public struct FillAnimationsFromControllerSystem : ISystem, ISystemCompilerGenerated
{

}
