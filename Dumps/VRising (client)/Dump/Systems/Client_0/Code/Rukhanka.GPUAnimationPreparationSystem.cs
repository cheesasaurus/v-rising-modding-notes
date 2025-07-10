using Unity.Entities;

namespace Rukhanka;


[UpdateInGroup(typeof(Rukhanka.RukhankaDeformationSystemGroup))]
[UpdateBefore(typeof(Rukhanka.GPUAnimationSystem))]
public struct GPUAnimationPreparationSystem : ISystem, ISystemCompilerGenerated
{

}
