using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.UpdateGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct MountInventorySystem_Server : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1228665425_0;
    EntityQuery __query_1228665425_1;
    EntityQuery __query_1228665425_2;
    
    // unmanaged system, skipped generating example queries

}
