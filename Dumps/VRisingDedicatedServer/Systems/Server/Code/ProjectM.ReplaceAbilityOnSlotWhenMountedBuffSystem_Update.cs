using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct ReplaceAbilityOnSlotWhenMountedBuffSystem_Update : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1545567486_0;
    EntityQuery __query_1545567486_1;
    
    // unmanaged system, skipped generating example queries

}
