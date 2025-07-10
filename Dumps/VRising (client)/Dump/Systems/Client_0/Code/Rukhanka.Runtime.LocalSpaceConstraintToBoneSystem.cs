using Unity.Entities;

namespace Rukhanka.Runtime;


[UpdateInGroup(typeof(Rukhanka.RukhankaAnimationSystemGroup), OrderLast = true)]
public struct LocalSpaceConstraintToBoneSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_1078489082_0;
    EntityQuery __query_1078489082_1;
    
    // unmanaged system, skipped generating example queries

}
