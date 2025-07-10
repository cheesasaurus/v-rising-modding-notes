using Unity.Entities;

namespace ProjectM;


[UpdateInGroup(typeof(ProjectM.ReactToPersistenceLoadedGroup))]
[RequireMatchingQueriesForUpdateAttribute]
public struct MountSystem_AddDisableWhenNoPlayersInRange : ISystem, ISystemCompilerGenerated
{
    EntityQuery __query_1228665797_0;
    
    // unmanaged system, skipped generating example queries

}
