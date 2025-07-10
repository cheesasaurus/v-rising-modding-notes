using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.PlayCommandSystemGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct CreateInputCommandsSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1790098998_0;
    EntityQuery __query_1790098998_1;
    EntityQuery __query_1790098998_2;
    EntityQuery __query_1790098998_3;
    
    // unmanaged system, skipped generating example queries

}
