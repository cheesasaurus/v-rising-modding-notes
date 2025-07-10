using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct UpdateChargingSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1100051645_0;
    EntityQuery __query_1100051645_1;
    
    // unmanaged system, skipped generating example queries

}
