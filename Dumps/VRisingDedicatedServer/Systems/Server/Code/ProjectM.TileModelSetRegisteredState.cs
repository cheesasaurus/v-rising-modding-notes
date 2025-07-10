using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToTransformGroup), OrderLast = true)]
public struct TileModelSetRegisteredState : ISystem, ISystemCompilerGenerated
{
    EntityQuery _ToRegisterQuery;
    EntityQuery _ToUnregisterQuery;
    EntityQuery _CustomDirtyEventQuery;
    EntityQuery __query_1714302195_0;
    
    // unmanaged system, skipped generating example queries

}
