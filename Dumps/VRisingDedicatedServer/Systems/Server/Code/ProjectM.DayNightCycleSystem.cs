using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.NoStructuralChangesGroup))]
[UpdateBefore(typeof(ProjectM.SunSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public struct DayNightCycleSystem : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1657221673_0;
    EntityQuery __query_1657221673_1;
    EntityQuery __query_1657221673_2;
    EntityQuery __query_1657221673_3;
    
    // unmanaged system, skipped generating example queries

}
