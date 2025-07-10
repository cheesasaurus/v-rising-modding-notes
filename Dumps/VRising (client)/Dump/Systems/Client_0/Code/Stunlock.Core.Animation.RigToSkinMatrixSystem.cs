using Unity.Entities;

namespace Stunlock.Core.Animation;


[UpdateInGroup(typeof(PresentationSystemGroup))]
[UpdateAfter(typeof(Stunlock.Core.Animation.AnimationSystem))]
public struct RigToSkinMatrixSystem : ISystem, ISystemCompilerGenerated
{

}
