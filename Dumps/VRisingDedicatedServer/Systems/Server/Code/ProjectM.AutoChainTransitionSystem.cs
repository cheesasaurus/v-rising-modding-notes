using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ScheduleGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct AutoChainTransitionSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _UpdateQuery;
    EntityQuery __query_1921791196_0;
    EntityQuery __query_1921791196_1;
    EntityQuery __query_1921791196_2;
    EntityQuery __query_1921791196_3;
    
    // unmanaged system, skipped generating example queries

}
