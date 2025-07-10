using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct MilitiaRiderBuffSystem_Update : ISystem, ISystemCompilerGenerated
{
    EntityQuery _Query;
    EntityQuery __query_21045749_0;
    EntityQuery __query_21045749_1;
    EntityQuery __query_21045749_2;
    
    // unmanaged system, skipped generating example queries

}
