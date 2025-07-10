using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct MarkerGuidanceSystem : ISystem, ISystemCompilerGenerated, ISystemStartStop
{
    EntityQuery _MarkerQuery;
    EntityQuery __query_1433655810_0;
    EntityQuery __query_1433655810_1;
    EntityQuery __query_1433655810_2;
    EntityQuery __query_1433655810_3;
    EntityQuery __query_1433655810_4;
    EntityQuery __query_1433655810_5;
    
    // unmanaged system, skipped generating example queries

}
