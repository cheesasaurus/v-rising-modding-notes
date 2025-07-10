using Unity.Entities;

namespace Rukhanka;


[UpdateInGroup(typeof(Rukhanka.RukhankaAnimationInjectionSystemGroup))]
[UpdateAfter(typeof(Rukhanka.AimIKSystem))]
[UpdateAfter(typeof(Rukhanka.FABRIKSystem))]
public struct TwoBoneIKSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_83362612_0;
    EntityQuery __query_83362612_1;
    
    // unmanaged system, skipped generating example queries

}
