using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct SetCurrentMapZoneSystem_Server : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1687715563_0;
    EntityQuery __query_1687715563_1;
    EntityQuery __query_1687715563_2;
    
    // unmanaged system, skipped generating example queries

}
