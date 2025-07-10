using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct StablesSystem_ReactToInventoryChanged : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_1751579259_0;
    EntityQuery __query_1751579259_1;
    EntityQuery __query_1751579259_2;
    
    // unmanaged system, skipped generating example queries

}
