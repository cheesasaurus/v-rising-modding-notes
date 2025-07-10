using Unity.Entities;

namespace Rukhanka;


[UpdateInGroup(typeof(Rukhanka.RukhankaAnimationSystemGroup))]
[UpdateAfter(typeof(Rukhanka.RukhankaAnimationInjectionSystemGroup))]
public struct AnimationApplicationSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery boneObjectEntitiesWithParentQuery;
    EntityQuery boneObjectEntitiesNoParentQuery;
    EntityQuery __query_465682245_0;
    EntityQuery __query_465682245_1;
    EntityQuery __query_465682245_2;
    
    // unmanaged system, skipped generating example queries

}
