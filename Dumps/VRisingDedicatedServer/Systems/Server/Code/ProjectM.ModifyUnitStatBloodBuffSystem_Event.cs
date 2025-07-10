using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToUnitStatChangedEventGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct ModifyUnitStatBloodBuffSystem_Event : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_998822607_0;
    EntityQuery __query_998822607_1;
    
    // unmanaged system, skipped generating example queries

}
