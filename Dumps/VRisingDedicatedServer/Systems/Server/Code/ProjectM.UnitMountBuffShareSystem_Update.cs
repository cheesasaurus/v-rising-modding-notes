using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct UnitMountBuffShareSystem_Update : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_1987576745_0;
    EntityQuery __query_1987576745_1;
    
    // unmanaged system, skipped generating example queries

}
