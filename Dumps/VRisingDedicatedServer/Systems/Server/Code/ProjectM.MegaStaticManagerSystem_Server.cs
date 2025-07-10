using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.BeforeSerializeBarrierGroup))]
public struct MegaStaticManagerSystem_Server : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_467135326_0;
    EntityQuery __query_467135326_1;
    
    // unmanaged system, skipped generating example queries

}
