using Unity.Entities;

namespace ProjectM.Hybrid;


[UpdateInGroup(typeof(PresentationSystemGroup), OrderFirst = true)]
[UpdateBefore(typeof(Stunlock.Core.Animation.AnimationSystem))]
[UpdateBefore(typeof(ProjectM.CameraPresentationGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct AnimationSystem_ResetAnimations : ISystem, ISystemCompilerGenerated
{

}
