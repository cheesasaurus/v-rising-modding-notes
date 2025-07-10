using Unity.Entities;

namespace Stunlock.Core.Animation;


[UpdateInGroup(typeof(PresentationSystemGroup), OrderFirst = true)]
public struct AnimationSystem : ISystem, ISystemCompilerGenerated
{

}
