using Unity.Entities;

namespace Rukhanka.Runtime;


[UpdateInGroup(typeof(Rukhanka.RukhankaAnimationSystemGroup))]
[UpdateBefore(typeof(Rukhanka.AnimationProcessSystem))]
[UpdateAfter(typeof(Rukhanka.FillAnimationsFromControllerSystem))]
public struct ScriptedAnimatorUpdateSystem : ISystem, ISystemCompilerGenerated
{

}
