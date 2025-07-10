using Unity.Entities;

namespace Rukhanka;


[UpdateInGroup(typeof(Rukhanka.RukhankaAnimationSystemGroup))]
[UpdateAfter(typeof(Rukhanka.AnimationCullingContextUpdateSystem))]
public struct AnimationCullingSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery cullAnimationTagQuery;
    EntityQuery __query_105584045_0;
    EntityQuery __query_105584045_1;
    EntityQuery __query_105584045_2;
    EntityQuery __query_105584045_3;
    
    // unmanaged system, skipped generating example queries

}
