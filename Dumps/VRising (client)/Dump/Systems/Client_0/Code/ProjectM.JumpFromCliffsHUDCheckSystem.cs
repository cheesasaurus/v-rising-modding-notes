using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ScheduleGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct JumpFromCliffsHUDCheckSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1619853863_0;
    EntityQuery __query_1619853863_1;
    EntityQuery __query_1619853863_2;
    
    // unmanaged system, skipped generating example queries

}
