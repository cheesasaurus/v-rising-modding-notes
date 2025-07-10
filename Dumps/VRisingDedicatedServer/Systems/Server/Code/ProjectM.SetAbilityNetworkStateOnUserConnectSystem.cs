using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.BeforeSerializeBarrierGroup))]
public struct SetAbilityNetworkStateOnUserConnectSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_1252398768_0;
    
    // unmanaged system, skipped generating example queries

}
