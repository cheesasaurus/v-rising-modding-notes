using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct SetCurrentMapZoneSystem_Client : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1687715655_0;
    
    // unmanaged system, skipped generating example queries

}
