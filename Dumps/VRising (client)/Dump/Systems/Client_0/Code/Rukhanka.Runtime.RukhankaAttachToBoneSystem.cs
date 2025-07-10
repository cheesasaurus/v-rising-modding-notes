using Unity.Entities;

namespace Rukhanka.Runtime;


[UpdateInGroup(typeof(SimulationSystemGroup))]
[UpdateAfter(typeof(Unity.Transforms.TransformSystemGroup))]
[UpdateAfter(typeof(Rukhanka.RukhankaAnimationSystemGroup))]
public struct RukhankaAttachToBoneSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_1571471943_0;
    EntityQuery __query_1571471943_1;
    
    // unmanaged system, skipped generating example queries

}
