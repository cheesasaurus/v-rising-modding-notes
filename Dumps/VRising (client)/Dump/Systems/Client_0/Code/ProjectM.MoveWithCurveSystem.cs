using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.MoveGroup))]
[UpdateBefore(typeof(ProjectM.PlayCommandSystemGroup))]
public struct MoveWithCurveSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_248587550_0;
    EntityQuery __query_248587550_1;
    
    // unmanaged system, skipped generating example queries

}
