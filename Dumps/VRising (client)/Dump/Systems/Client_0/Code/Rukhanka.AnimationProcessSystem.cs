using Unity.Entities;

namespace Rukhanka;


[UpdateInGroup(typeof(Rukhanka.RukhankaAnimationSystemGroup))]
[UpdateAfter(typeof(Rukhanka.AnimationCullingSystem))]
public struct AnimationProcessSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery animatedObjectQuery;
    EntityQuery __query_106342387_0;
    EntityQuery __query_106342387_1;
    EntityQuery __query_106342387_2;
    EntityQuery __query_106342387_3;
    
    // unmanaged system, skipped generating example queries

}
