using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.BeforeTransformSystemGroup))]
public struct BeforeTileModelUpdate : ISystem, ISystemCompilerGenerated
{
    EntityQuery _ToRegisterQuery;
    EntityQuery _ToUnregisterQuery;
    EntityQuery __query_1714302096_0;
    
    // unmanaged system, skipped generating example queries

}
