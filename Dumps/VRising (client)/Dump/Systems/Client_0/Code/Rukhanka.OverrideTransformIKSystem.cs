using Unity.Entities;

namespace Rukhanka;


[UpdateInGroup(typeof(Rukhanka.RukhankaAnimationInjectionSystemGroup))]
[UpdateAfter(typeof(Rukhanka.FABRIKSystem))]
public struct OverrideTransformIKSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1670967333_0;
    EntityQuery __query_1670967333_1;
    
    // unmanaged system, skipped generating example queries

}
