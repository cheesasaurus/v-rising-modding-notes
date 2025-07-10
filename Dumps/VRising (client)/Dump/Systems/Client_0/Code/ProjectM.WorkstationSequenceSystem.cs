using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct WorkstationSequenceSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_1457219060_0;
    EntityQuery __query_1457219060_1;
    EntityQuery __query_1457219060_2;
    
    // unmanaged system, skipped generating example queries

}
