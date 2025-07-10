using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.MoveGroup))]
[UpdateAfter(typeof(ProjectM.MoveWithCurveSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public struct MoveEntitySystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1244541736_0;
    EntityQuery __query_1244541736_1;
    EntityQuery __query_1244541736_2;
    
    // unmanaged system, skipped generating example queries

}
