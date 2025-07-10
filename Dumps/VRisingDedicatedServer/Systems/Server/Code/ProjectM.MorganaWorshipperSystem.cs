using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct MorganaWorshipperSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery _WorshippersQuery;
    EntityQuery __query_1427996443_0;
    EntityQuery __query_1427996443_1;
    
    // unmanaged system, skipped generating example queries

}
