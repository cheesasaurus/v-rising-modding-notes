using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[UpdateBefore(typeof(ProjectM.UnitCompositionSpawnerSystem))]
[RequireMatchingQueriesForUpdateAttribute]
public struct UnitCompositionSpawnerSystem_CheckTime : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_707728742_0;
    EntityQuery __query_707728742_1;
    EntityQuery __query_707728742_2;
    EntityQuery __query_707728742_3;
    
    // unmanaged system, skipped generating example queries

}
